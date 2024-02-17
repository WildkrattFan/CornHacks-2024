package Cornhacks2024;

import java.util.Scanner;

public class dragonsLair {
    Dice dice = new Dice();

    public static void magicWizardHand(){
        System.out.println("Congrats you rolled a 16");
        System.out.println("You zap the dragon with your magic wiazrd hands and you kill the Dragon");
            southMountains(player);     
    } 
    public static void runAway(int roll){
        System.out.println("You rolled a " + roll);
        System.out.println("You try run away from the Dragon");
        System.out.println("Will you dodge the Dragon?");
        System.out.println("Type 'yes' or 'no'");
        runTrue = scanner.nextLine();
        if runTrue.equals("yes") {
            roll = dice.rollMediumChoice();
            if (roll >= 6) {
                System.out.println("You rolled a " + roll);
                System.out.println("Congrats, you have dodged the Dragon");
                southMountains(player);
            } else {
                System.out.println("You rolled a " + roll);
                System.out.println("The Dragon hits you with a wrath of envious fire \n you die");
                System.exit(0);
            }
        }
    }
    public static void readyToDieMessage(){
        System.out.println("Are you ready to die");
        System.out.println("Type 'yes' or 'no'");
    } 
    public static void dragonInLair(){
        System.out.println("Dragon in Lair");
        System.out.println("The Dragon sees you how would you like to react");
        String choice = scanner.nextLine();
        System.out.println("Silly choice I have a better one");
        roll = dice.rollHardChoice();
        if (roll == 16){
            magicWizardHand();
        } else if (roll >= 12){
            runAway();
        }
    }
    public static void dragonNotInLair(){
        System.out.println("You enter ");

    public static void dragonsLair(player) {
        System.out.println("Welcome to the Dragon's Lair");
        readyToDieMessage();
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        while (input.equals("yes") == false) {
            String input = scanner.nextLine();
            System.out.println("SORRY WRONG ANSWER!!! \n Lets try that again...");
            readyToDieMessage();
            }
        int roll = dice.rollEasyChoice()
        if (roll <= 3){
            dragonInLair();
        } else {
            dragonNotInLair();
        }
            
        }
    }
}



        