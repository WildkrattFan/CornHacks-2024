package Cornhacks2024;

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
            if (dice.rollEasyChoice() <= 4) {
                System.out.println("You have rolled a " + dice.rollEasyChoice() + " the game will now begin!");
                System.out.println("Good luck!");
                gameAeraOne(inventory); 
            } else {
                System.out.println("You have rolled a " + dice.rollEasyChoice() + ".");
                System.out.println("You have died. Game over.");
                System.exit(1);
            }
        } else if (input.equals("no")) {
            //Play DIce animation
            if (dice.rollEasyChoice() <= 4){
                System.out.printkn("You have rolled a " + dice.rollEasyChoice() + " the game will now end.");
                System.out.println("Thank you for playing. Goodbye!");
            else {
                System.out.println("You have rolled a " + dice.rollEasyChoice() + ". The game will now begin!");
                System.out.println("Womp womp.");
                gameAeraOne(inventory);
            }
            
            System.exit(0);
        } else {
            System.out.println("Invalid input. Please type 'yes' or 'no'.");
        }
}

    // Game Area 1
    public static void gameAeraOne(List<Item> inventory) {

        System.out.println("Wizzard: Greetings Traveler! Welcome to my humble abode. What should I call you?");
        String name = System.console().readLine();
        // User input name
        if (dice.rollMediumChoice() >= 5) {
            character player = new character(name);
        } else {
            System.out.println("Wizzard: " + name + " is a terrible name. I will call you Bob.");
            character player = new character("Bob");
        }

    }
}