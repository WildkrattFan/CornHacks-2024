package Cornhacks2024;

import java.util.List;
import java.util.ArrayList;

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
            // Play Dice animation
            if (dice.rollEasyChoice() <= 4) {
                System.out.println("You have rolled a " + dice.rollEasyChoice() + " the game will now begin!");
                System.out.println("Good luck!");
                gameAeraOne(); 
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
                gameAeraOne();
            }
            
            System.exit(0);
        } else {
            System.out.println("Invalid input. Please type 'yes' or 'no'.");
        }
}

    // Wizard Hut Area
    public static void gameAeraOne() {

        System.out.println("Wizard: Greetings Traveler! Welcome to my humble abode. What should I call you?");
        String name = System.console().readLine();
        // User input name
        character player; // Declare the player variable outside of the if-else block
        if (dice.rollMediumChoice() >= 5) {
            player = new character(name);
        } else {
            System.out.println("Wizzard: " + name + " is a terrible name. I will call you Bob.");
            player = new character("Bob");
        }

        // Choose to accept or decline the quest
        System.out.println("Wizard: " + player.getName() + " I have a quest for you.");
        System.out.println(
                "Wizard: I need you to travel north to the cave of wonders and retrieve the magical gauntlet of power!");
        System.out.println("Wizard: Are you up to the task?");
        // Player input yes or no
        String input = System.console().readLine();

        // Accepts the quest
        if (input.equals("yes")) {

            // Choice success!
            if (dice.rollMediumChoice() >= 5) {

                System.out.println("Wizard: Excellent! I knew I could count on you " + player.getName() + ".");
                System.out.println("Wizard: Here is a map to the cave. Good luck!");
                System.out.println("Would you like to head to the South or to the East?");
                String direction = System.console().readLine();

                if (direction.equals("south")) {

                } else if (direction.equals("east")) {
                    System.out.println("You have chosen to head east.");
                    gameAreaTwo(player);
                } else {
                    System.out.println("I'm sorry, I didn't catch that. Please type 'south' or 'east'.");
                }

            } else {
                System.out.println("Wizard: I see. Well, I guess I will have to find someone else to do it.");
                System.out.println("Wizard: Goodbye " + player.getName() + ".");
                System.exit(0);
            }
            gameAreaTwo(player);

            // Declines the quest
        } else if (input.equals("no")) {
            System.out.println("Wizard: I see. Well, I guess I will have to find someone else to do it.");
            System.out.println("Wizard: Goodbye " + player.getName() + ".");
            System.exit(0);
        } else {
            System.out.println("Wizard: I'm sorry, I didn't catch that. Please type 'yes' or 'no'.");
        }

    }
}