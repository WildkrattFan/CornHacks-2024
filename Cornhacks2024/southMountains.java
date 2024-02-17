package Cornhacks2024;

public class southMountains {
    public static void exploreSouthMountains(character player) {
        System.out.println("You enter the southern mountains...");
        System.out.println("Mountains sprawl before you as far as the eye can see.");
        System.out.println("It is truely a sight to behold.");
        System.out.println("You feel a sense of adventure and wonder.");
        System.out.println("You feel as though you could take on the world.");
        dice diceInstance = new dice();
        int roll = diceInstance.rollMediumChoice();

        if (roll >= 5) {
            System.out.println("You rolled a " + roll);
            System.out.println("You feel a sense of adventure and wonder.");
            System.out.println("You feel as though you could take on the world.");
            rushDownMountain(player);
        } else {
            System.out.println("You rolled a " + roll);
            System.out.println("You get a sudden sense of dread.");
            System.out.println("You feel as though you should turn back.");
            System.out.println("Turn back now.");
            System.out.println("Get out of here.");
            System.out.println("Get out!");
            System.out.println("OUT OUT OUT OUT OUT OUT OUT!!!");
            depressed(player);
        }
    }

    public static void rushDownMountain(character player) {
        System.out.println("You sprint down the mountain with the speed of the fastest horses.");
        System.out.println("You feel the wind in your hair and the sun on your face.");
        System.out.println("You feel alive.");
        System.out.println("You feel free.");
        System.out.println("You feel like you could take on the world.");

        dice diceInstance = new dice();
        int roll = diceInstance.rollMediumChoice();
        if (roll >= 7) {
            System.out.println("You rolled a " + roll);
            System.out.println("You make it down the mountainside safely.");
        } else {
            System.out.println("You rolled a " + roll);
            System.out.println("You trip and fall down the mountainside.");
            System.out.println("You are injured and cannot continue.");
            depressed(player);
        }
    }

    public static void depressed(character player) {
        dice diceInstance = new dice();
        int roll = diceInstance.rollMediumChoice();
        System.out.println("You feel a sense of dread and despair.");
        System.out.println("You feel as though you have failed.");

        if (roll <= 7) {
            System.out.println("You rolled a " + roll);
            System.out.println("You fall to your knees and weep.");
            System.out.println("Would you like to try and continue?");
            String input = System.console().readLine();
            if (input.equals("yes")) {
                dice diceInstance2 = new dice();
                int roll2 = diceInstance2.rollMediumChoice();
                if (roll2 >= 7) {
                    System.out.println("You rolled a " + roll2);
                    System.out.println("You feel a sense of determination.");
                    System.out.println("You feel as though you could take on the world.");
                    rushDownMountain(player);
                } else {
                    System.out.println("You rolled a " + roll2);
                    System.out.println("Your dread continues to escalate and you are unable to conunue");
                    System.exit(1);
                }
            } else {
                dice diceInstance3 = new dice();
                int roll3 = diceInstance3.rollMediumChoice();
                if (roll3 >= 7) {
                    System.out.println("You rolled a " + roll3);
                    System.out.println("You feel a sense of determination.");
                    System.out.println("You feel as though you could take on the world.");
                    rushDownMountain(player);
                } else {
                    System.out.println("You rolled a " + roll3);
                    System.out.println("You turn back and leave the mountains. Forever haunted by the dread you felt.");
                    System.exit(1);
                }
            }

        }

    }
}