package Cornhacks2024;

import java.util.Scanner;

public class dragonsLair {
    Dice dice = new Dice();
    public static void readyToDieMessage(){
        System.out.println("Are you ready to die");
        System.out.println("Type 'yes' or 'no'");
    } 
    public static void dragonInLair(){
        System.out.println("Dragon in Lair");
        System.out.println("The Dragon sees you how would you like to react");
        



    }
    public static void dragonNotInLair(){
        System.out.println("You enter ")

    public static void dragonsLair() {
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



        