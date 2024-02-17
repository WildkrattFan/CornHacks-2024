package Cornhacks2024;

public class textAdventureBase {

    public static void main(String[] args) {
        // Start the game

        System.out.println("Welcome to the amazing world of Valdoria brave adentureer!");
        System.out.println("You are about to embark on a journey that will test your wits and courage.");
        System.out.println(
                "You will face many challenges and make many choices all of which will depend on... Your luck!");
        System.out.println("Are you ready to begin your adventure?");
        System.out.println("Type 'yes' to begin or 'no' to exit the game.");
        String input = System.console().readLine();
        if (input.equals("yes")) {
            // Create an instance of the dice class
            dice diceInstance = new dice();

            // Play Dice animation
            if (diceInstance.rollEasyChoice() <= 4) {
                System.out.println("You have rolled a " + diceInstance.rollEasyChoice() + " the game will now begin!");
                System.out.println("Good luck!");
                gameAreaOne.gameAeraOne();
            } else {
                System.out.println("You have rolled a " + diceInstance.rollEasyChoice() + ".");
                System.out.println("You have died. Game over.");
                System.exit(1);
            }
        } else if (input.equals("no")) {
            // Play DIce animation
            dice dice = new dice();
            if (dice.rollEasyChoice() <= 4) {
                System.out.println("You have rolled a " + dice.rollEasyChoice() + " the game will now end.");
                System.out.println("Thank you for playing. Goodbye!");
            } else {
                System.out.println("You have rolled a " + dice.rollEasyChoice() + ". The game will now begin!");
                System.out.println("Womp womp.");
                gameAreaOne.gameAeraOne();
            }

            System.exit(0);
        } else {
            System.out.println("Invalid input. Please type 'yes' or 'no'.");
        }

    }
}
