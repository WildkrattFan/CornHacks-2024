import java.util.List;
import java.util.ArrayList;

public class textAdventureBase {

    public static void main(String[] args) {
        // Start the game
        List<String> inventory = new ArrayList<String>();
        System.out.println("Welcome to the amazing world of Valdoria brave adentureer!");
        System.out.println("You are about to embark on a journey that will test your wits and courage.");
        System.out.println(
                "You will face many challenges and make many choices all of which will depend on... Your luck!");
        System.out.println("Are you ready to begin your adventure?");
        System.out.println("Type 'yes' to begin or 'no' to exit the game.");
        String input = System.console().readLine();
        if (input.equals("yes")) {
            // Play Dice animation
            if (Dice.rollEasyChoice() >= 4) {
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
            if (Dice.rollEasyChoice() >= 4){
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
}

gameAeraOne(){

}
}