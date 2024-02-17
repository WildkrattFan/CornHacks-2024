import java.util.List;
import java.util.ArrayList;

public class textAdventureBase {

    public static void main(String[] args) {
        // Start the game
        List<Item> inventory = new ArrayList<>();
        System.out.println("Welcome to the amazing world of Valdoria brave adentureer!");
        System.out.println("You are about to embark on a journey that will test your wits and courage.");
        System.out.println(
                "You will face many challenges and make many choices all of which will depend on... Your luck!");
        System.out.println("Are you ready to begin your adventure?");
        System.out.println("Type 'yes' to begin or 'no' to exit the game.");
        String input = System.console().readLine();
        if (input.equals("yes")) {
            // Play Dice animation
            if (dice.rollEasyChoice() >= 4) {
                System.out.println("You have rolled a " + Dice.rollEasyChoice() + " the game will now begin!");
                System.out.println("Good luck!");
                gameAeraOne(invintory);
            } else {
                System.out.println("You have rolled a " + Dice.rollEasyChoice() + ".");
                System.out.println("You have died. Game over.");
                System.exit(1);
            }
        } else if (input.equals("no")) {
            //Play DIce animation
            if (dice.rollEasyChoice() >= 4){
                System.out.printkn("You have rolled a " + Dice.rollEasyChoice() + " the game will now end.");
                System.out.println("Thank you for playing. Goodbye!");
            else {
                System.out.println("You have rolled a " + Dice.rollEasyChoice() + ". The game will now begin!");
                System.out.println("Womp womp.");
                gameAeraOne(invintory);
            }
            
            System.exit(0);
        } else {
            System.out.println("Invalid input. Please type 'yes' or 'no'.");
        }
}

    public static void gameAeraOne(List<Item> inventory) {
        System.out
                .println("You are standing in a dark forest. You can see a path to the north and a path to the east.");
        System.out.println("Which way would you like to go?");
        String input = System.console().readLine();
        if (input.equals("north")) {
            System.out.println("You have chosen to go north.");
            gameAreaTwo(inventory);
        } else if (input.equals("east")) {
            System.out.println("You have chosen to go east.");
            gameAreaThree(inventory);
        } else {
            System.out.println("Invalid input. Please type 'north' or 'east'.");
        }

    }
}