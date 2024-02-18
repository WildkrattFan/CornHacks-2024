package Cornhacks2024;

import java.util.Scanner;

public class goblinEncounter {
    private static Scanner scanner = new Scanner(System.in);
    private static dice dice = new dice();

    public static void uglyGoblin(character player) {
        System.out.println("What are you staring at? Do you want a fight?");
        System.out.println("Type 'yes' or 'no'");
        String response = scanner.nextLine();
        if (response.equalsIgnoreCase("yes")) {
            goblinFight(player);
        } else if (response.equalsIgnoreCase("no")) {
            System.out.println("You chose not to fight. The goblin decides to fight you anyway.");
            simulateFight(player);
        } else {
            System.out.println("Invalid response. Please type 'yes' or 'no'.");
            uglyGoblin(player); // Call the method again to ask for a valid response
        }
    }

    public static void goblinFight(character player) {
        System.out.println("You chose to fight the ugly goblin!");
        simulateFight(player);
    }

    public static void simulateFight(character player) {
        System.out.println("Rolling the easy dice to decide the outcome of the fight...");
        int diceResult = dice.rollEasyChoice();
        System.out.println("You rolled: " + diceResult);
        if (diceResult > 2) {
            System.out.println("You defeated the goblin!");
            System.out.println("Or did you?");
            System.out.println("Is that all you got big guy?");
            System.out.println("Rolling the medium dice to decide the outcome of the fight...");
            int diceResult2 = dice.rollMediumChoice();
            System.out.println("You rolled: " + diceResult2);
            if (diceResult2 > 6) {
                System.out.println("You continue to the east!");
                eastVillage.eastVillagePlace(player); // Handle victory scenario
            } else {
                System.out.println("The goblin defeated you!");
                System.exit(1); // Handle defeat scenario
            }
        } else {
            System.out.println("The goblin defeated you!");
            System.exit(1); // Handle defeat scenario
        }
    }
}
