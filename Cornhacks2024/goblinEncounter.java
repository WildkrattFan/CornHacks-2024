package Cornhacks2024;

import java.util.Scanner;

public class goblinEncounter {
    private static Scanner scanner = new Scanner(System.in);
    private static dice dice = new dice();

    public static void uglyGoblin(character player) {
        System.out.println("What are you staring at? Do you want a fight?");
        System.out.println("Type 'yes' or 'no'");
        String response = scanner.nextLine();
        if(response.equalsIgnoreCase("yes")) {
            goblinFight(player);
        } else if(response.equalsIgnoreCase("no")) {
            System.out.println("You chose not to fight. The goblin decides to fight you anyway.");
            System.out.println("Rolling the dice to decide the outcome of the fight...");

            int diceResult = dice.rollMediumChoice();
            System.out.println("You rolled: " + diceResult);

            if (diceResult > 10) {
                System.out.println("You defeated the goblin!");
                System.out.println("You continue to the east!");
                eastVillage.eastVillagePlace(player);
                // Handle victory scenario
            } else {
                System.out.println("The goblin defeated you!");
                System.exit(1);
                // Handle defeat scenario
            }
        } else {
            System.out.println("Invalid response. Please type 'yes' or 'no'.");
        }
    }

    public static void goblinFight(character player) {
        uglyGoblin(player);
        String response = scanner.nextLine();

        if (response.equalsIgnoreCase("yes")) {
            System.out.println("You chose to fight the ugly goblin!");
            System.out.println("Rolling the dice to decide the outcome of the fight...");

            int diceResult = dice.rollMediumChoice();
            System.out.println("You rolled: " + diceResult);

            if (diceResult > 10) {
                System.out.println("You defeated the goblin!");
                // Handle victory scenario
            } else {
                System.out.println("The goblin defeated you!");
                // Handle defeat scenario
            }
        } else if (response.equalsIgnoreCase("no")) {
            System.out.println("You chose not to fight. The goblin decides to fight you anyway.");
            System.out.println("Rolling the dice to decide the outcome of the fight...");

            int diceResult = dice.rollMediumChoice();
            System.out.println("You rolled: " + diceResult);

            if (diceResult > 10) {
                System.out.println("You defeated the goblin!");
                // Handle victory scenario
            } else {
                System.out.println("The goblin defeated you!");
                // Handle defeat scenario
            }
        } else {
            System.out.println("Invalid response. Please type 'yes' or 'no'.");
        }
    }
}
