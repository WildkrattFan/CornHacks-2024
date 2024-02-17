package Cornhacks2024;

public class southMountains {
    public static void exploreSouthMountains(character player) {
        System.out.println("You enter the southern mountains...");
        System.out.println("Mountains sprawl before you as far as the eye can see.");
        System.out.println("It is truely a sight to behold.");
        System.out.println("You feel a sense of adventure and wonder.");
        System.out.println("You feel as though you could take on the world.");
        int roll = dice.rollMediumChoice();

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
    }

    public static void depressed(character player) {
        int roll = dice.rollMediumChoice();
        System.out.println("You feel a sense of dread and despair.");
        System.out.println("You feel as though you have failed.");

        if (roll <= 7) {
            System.out.println("You rolled a " + roll);
            System.out.println("You fall to your knees and weep.");
            System.out.println("Would you like to try and continue?");
            String input = System.console().readLine();
            if (input.equals("yes")) {
                int roll2 = dice.rollMediumChoice();
                if (roll2 >= 7) {
                    System.out.println("You rolled a " + roll2);
                    System.out.println("You feel a sense of determination.");
                    System.out.println("You feel as though you could take on the world.");
                    rushDownMountain(player);
                } else {
                    System.out.println("You rolled a " + roll2);
                    System.out.println("Your dread continues to escalate and you are unable to continue");
                    System.exit(1);
                }
            } else {
                int roll3 = dice.rollMediumChoice();
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