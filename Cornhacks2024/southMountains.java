package Cornhacks2024;

//TODO: Cave of wonders() -- Success
//TODO: Mugged() -- Failure --- done

public class southMountains {
    public static void exploreSouthMountains(character player) {
        System.out.println("You enter the southern mountains...");
        System.out.println("Mountains sprawl before you as far as the eye can see.");
        System.out.println("It is truely a sight to behold.");
        System.out.println("You feel a sense of adventure and wonder.");
        System.out.println("You feel as though you could take on the world.");
        dice diceObject = new dice();
        int roll = diceObject.rollMediumChoice();

        if (roll >= 5) {
            System.out.println("You rolled a " + roll);
            System.out.println("You feel a sense of adventure and wonder.");
            System.out.println("You feel as though you could take on the world.");

            // 5/10 CHANCE OF RUSHING DOWN MOUNTAIN
            rushDownMountain(player);
        } else {
            System.out.println("You rolled a " + roll);
            System.out.println("You get a sudden sense of dread.");
            System.out.println("You feel as though you should turn back.");
            System.out.println("Turn back now.");
            System.out.println("Get out of here.");
            System.out.println("Get out!");
            System.out.println("OUT OUT OUT OUT OUT OUT OUT!!!");
            // 5/10 CHANCE OF DEPRESSION
            depressed(player);
        }
    }

    public static void rushDownMountain(character player) {
        dice diceObject = new dice();
        int roll = diceObject.rollMediumChoice();
        dice diceObject2 = new dice();
        int roll2 = diceObject2.rollMediumChoice();
        System.out.println("You sprint down the mountain with the speed of the fastest horses.");
        System.out.println("You feel the wind in your hair and the sun on your face.");
        System.out.println("You come to a stop at the base of the mountain, feeling invigorated.");
        // 5/10 CHANCE OF SPOTTING SOMETHING
        if (roll >= 5) {
            System.out.println("You rolled a " + roll);
            System.out.println("You suddenly spot something in the distance.");
            System.out.println("Would you like to investigate?");
            String input = System.console().readLine();
            if (input.equals("yes")) {

                if (roll2 >= 5) {
                    System.out.println("You rolled a " + roll2);
                    System.out.println("You find a cave in the distance.");
                    System.out.println("You feel a sense of wonder and excitement.");
                    System.out.println("You feel as though you could take on the world.");
                    // 5/10 CHANCE OF CAVE OF WONDERS
                    caveOfWonders.crypticCrystals(player);
                } else {
                    // 5/10 CHANCE OF RANDOMLY LEAVING
                    System.out.println("You turn back and leave the mountains.");
                    System.out.println("You feel as though you have missed out on something great.");
                    System.exit(1);
                }

            } else {
                if (roll2 < 5) {
                    System.out.println("You rolled a " + roll2 + " and have no choice but to investigate.");
                    System.out.println("You find a cave in the distance.");
                    System.out.println("You feel a sense of wonder and excitement.");
                    System.out.println("You feel as though you could take on the world.");
                    // 5/10 CHANCE OF CAVE OF WONDERS
                    caveOfWonders.crypticCrystals(player);
                } else {
                    System.out.println("You turn back and leave the mountains.");
                    System.out.println("You are suddenly attacked by a group of bandits!");
                    // 5/10 CHANCE OF MUGGED
                    mugged(player);
                }
            }

        } else {
            System.out.println("You rolled a " + roll);
            System.out.println("You feel a sense of dread and despair.");
            System.out.println("You feel as though you have failed.");
            // 5/10 CHANCE OF DEPRESSION
            depressed(player);
        }

    }

    public static void depressed(character player) {
        dice diceObject = new dice();
        int roll = diceObject.rollMediumChoice();
        System.out.println("You feel a sense of dread and despair.");
        System.out.println("You feel as though you have failed.");

        if (roll <= 7) {
            System.out.println("You rolled a " + roll);
            System.out.println("You fall to your knees and weep.");
            System.out.println("Would you like to try and continue?");
            String input = System.console().readLine();
            if (input.equals("yes")) {
                int roll2 = diceObject.rollMediumChoice();
                if (roll2 >= 7) {
                    System.out.println("You rolled a " + roll2);
                    System.out.println("You feel a sense of determination.");
                    System.out.println("You feel as though you could take on the world.");
                    // 7/10 CHANCE OF RUSHING DOWN MOUNTAIN
                    rushDownMountain(player);
                } else {
                    // 3/10 CHANCE OF DEPRESSION CAUSING YOU TO LEAVE
                    System.out.println("You rolled a " + roll2);
                    System.out.println("Your dread continues to escalate and you are unable to continue");
                    System.exit(1);
                }
            } else {
                int roll3 = diceObject.rollMediumChoice();
                if (roll3 >= 7) {
                    System.out.println("You rolled a " + roll3);
                    System.out.println("You feel a sense of determination.");
                    System.out.println("You feel as though you could take on the world.");
                    // 7/10 CHANCE OF RUSHING DOWN MOUNTAIN
                    rushDownMountain(player);
                } else {
                    // 3/10 CHANCE OF DEPRESSION CAUSING YOU TO LEAVE
                    System.out.println("You rolled a " + roll3);
                    System.out.println("You turn back and leave the mountains. Forever haunted by the dread you felt.");
                    System.exit(1);
                }
            }

        }

    }

    public static void mugged(character player) {
        System.out.println("You are outnumbered and outmatched.");
        System.out.println("Would you like to fight or surrender?");
        String input = System.console().readLine();

        if (input.equals("fight")) {
            dice diceObject = new dice();
            int roll = diceObject.rollHardChoice();
            if (roll >= 10) {
                System.out.println("You rolled a " + roll);
                System.out.println("You are able to fight off the bandits and escape.");
                System.out.println("You leave the mountains and continue on your journey.");
                System.out.println("Along the way you run into the Cave of Wonders!");
                // 1/10 CHANCE OF ESCAPING TO CAVE OF WONDERS
                caveOfWonders.crypticCrystals(player);
            } else {
                // 9/10 CHANCE OF DYING TO BANDITS
                System.out.println("You rolled a " + roll);
                System.out.println("You are quickly overpowered and killed.");
                System.exit(1);
            }
        } else {
            System.out.println("You decide to surrender!");
            dice diceObject = new dice();
            int roll = diceObject.rollHardChoice();
            if (roll >= 10) {
                // 9/10 CHANCE OF BEING ENSLAVED
                System.out.println("You rolled a " + roll);
                System.out.println("The bandits accept your surrender and take you as their servant.");
                System.out.println("You are forced to work for them for the rest of your life.");
                System.exit(1);
            } else {
                // 1/10 CHANCE OF DYING TO BANDITS
                System.out.println("You rolled a " + roll);
                System.out.println("The bandits do not accept your surrender.");
                System.out.println("You are quickly overpowered and killed.");
                System.exit(1);
            }
        }
    }
}