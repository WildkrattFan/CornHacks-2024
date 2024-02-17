package Cornhacks2024;

import java.util.Scanner;

public class caveOfWonders {
    private static Scanner scanner = new Scanner(System.in);
    private static dice dice = new dice();

    public static void crypticCrystals() {
        System.out.println("Answer our riddles or be trapped in this cave forever!");
        System.out.println("Type 'yes' or 'no'");
    }

    public static void crystalRiddles() {
        crypticCrystals();
        String response = scanner.nextLine();

        if (response.equalsIgnoreCase("yes")) {
            // First Riddle
            System.out.println(
                    "Riddle 1: I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I?");
            if (rollForHint(dice.rollEasyChoice(), 4)) {
                System.out.println(
                        "Hint: The answer is a common phenomenon in nature, often heard in the rustling of leaves.");
            }
            System.out.println("Enter your answer: ");
            String answer1 = scanner.nextLine();

            if (answer1.equalsIgnoreCase("echo") || answer1.equalsIgnoreCase("echoes")) {
                System.out.println("Correct! You have answered the first riddle.");
            } else {
                System.out.println("Incorrect. You are trapped in the cave.");
                return; // End the game if the answer is wrong
            }

            // Second Riddle
            System.out.println("Riddle 2: What has a head, a tail, is brown, and has no legs?");
            if (rollForHint(dice.rollMediumChoice(), 7)) {
                System.out.println("Hint: This object is commonly associated with wealth and currency.");
            }
            System.out.println("Enter your answer: ");
            String answer2 = scanner.nextLine();

            if (answer2.equalsIgnoreCase("coin") || answer2.equalsIgnoreCase("coins")) {
                System.out.println("Correct! You have answered the second riddle.");
            } else {
                System.out.println("Incorrect. You are trapped in the cave.");
                return; // End the game if the answer is wrong
            }

            // Third Riddle
            System.out.println("Riddle 3: The more you take, the more you leave behind. What am I?");
            if (rollForHint(dice.rollHardChoice(), 10)) {
                System.out.println("Hint: Think about your actions when you walk.");
            }
            System.out.println("Enter your answer: ");
            String answer3 = scanner.nextLine();

            if (answer3.equalsIgnoreCase("footsteps")) {
                System.out.println("Correct! You have answered the third riddle.");
                System.out.println("Congratulations! You've won the game and received the Gauntlet of Eternity!");
            } else {
                System.out.println("Incorrect. You are trapped in the cave.");
            }
        } else {
            System.out.println("You chose not to answer the riddles. Game over.");
        }
    }

    /**
     * rollForHint is a helper function that prompts the user to roll a die and
     * displays a hint if the roll is low enough.
     *
     * @param roll      the result of the die roll
     * @param threshold the minimum roll value required to display the hint
     * @return true if the roll is high enough to receive a hint, false otherwise
     */
    public static boolean rollForHint(int roll, int threshold) {
        System.out.println("Roll your dice for a hint!");
        System.out.println("You rolled: " + roll);
        return roll >= threshold;
    }

    public static void crypticCrystals(character player) {
        crystalRiddles();
    }
}
