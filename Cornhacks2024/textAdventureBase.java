package Cornhacks2024;

public class textAdventureBase {

    public static void main(String[] args) {
        // Start the game

        System.out.println("Welcome to the amazing world of Valdoria brave adentureer!");
        System.out.println("You are about to embark on a journey that will test your wits and courage.");
        System.out.println("You will face many challenges and make many choices all of which will depend on... Your luck!");
        System.out.println("Are you ready to begin your adventure?");
        System.out.println("Type 'yes' to begin or 'no' to exit the game.");
        String input = System.console().readLine();
        if (input.equals("yes")) {
            // Create an instance of the dice class
            System.out.println("Magnificent, to help you on your journey I shall");
            dice diceInstance = new dice();
            int rollChoice = diceInstance.rollEasyChoice();

            // Play Dice animation
            if (rollChoice != 1) {
                System.out.println("You have rolled a " + rollChoice + " the game will now begin!");
                System.out.println("Good luck!");
                gameAreaOne.gameAeraOne();
            } else {
                System.out.println("You have rolled a " + rollChoice + ".");
                System.out.println("You have died. Game over.");
                System.exit(1);
            }
        } else if (input.equals("no")) {
            // Play DIce annimation
            dice dice = new dice();
            int rollChoice2 = dice.rollEasyChoice();
            if (rollChoice2 <= 4) {
                System.out.println("You have rolled a " + rollChoice2 + " the game will now end.");
                System.out.println("Thank you for playing. Goodbye!");
            } else {
                System.out.println("You have rolled a " + rollChoice2 + ". The game will now begin!");
                System.out.println("Womp womp.");
                gameAreaOne.gameAeraOne();
            }

            System.exit(0);
        } else {
            System.out.println("Invalid input. Please type 'yes' or 'no'.");
        }

    }
}
