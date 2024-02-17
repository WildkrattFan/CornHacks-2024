import java.util.Scanner;

public class eastVillage {
    Dice dice = new Dice(); 
    public static void adventure(Character player, Dice dice) {
        int roll = dice.rollHardChoice();
            if (roll >= 8) {
                System.out.println("You rolled a " + roll + ". You go on an adventure to the cave of wonders");
                caveofWonders.caveofWonders(player);
            } else {
                System.out.println("You rolled a " + " and you have died on your first adventure. Game over.");
                System.exit(0);
            }

    public static void eastVillagePlace(Character player) {
        System.out.println("You are now in East Village");
        System.out.println("Do you want to become an adventurer? ('yes' or 'no')");
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        if (input.equals("no")) {
            System.out.println("Too bad you become and adventurer anyways :)");
        }
        System.out.println("You are now an adventurer!");
        System.out.println("Do you want to go on an adventure? ('yes' or 'no')");
        String input2 = scanner.nextLine();
            if (input2.equals("yes")) {
                adventure();
            } else {
                System.out.println("You settle down in East Village but always regret  \n that you never became an adventurer");
                System.out.println("You die of old age, Game over");
                System.exit(0);
            }
         
    }
}