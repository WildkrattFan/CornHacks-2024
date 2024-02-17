package Cornhacks2024;

//TODO

// Make dragonsLair() -- Failure
// Make goblinEncounter() -- Failure
// Make southMountains() -- Success
// Make eastVillage() -- Success

public class gameAreaOne {
    public static void gameAeraOne() {

        System.out.println("Wizard: Greetings Traveler! Welcome to my humble abode. What should I call you?");
        dice diceInstance = new dice(); // Create an instance of the dice class
        String name = System.console().readLine();
        character player; // Declare the player variable outside of the if-else statement
        // User input name
        if (diceInstance.rollMediumChoice() >= 5) { // Use the diceInstance to call the rollMediumChoice() method
            player = new character(name);
        } else {
            System.out.println("Wizzard: " + name + " is a terrible name. I will call you Bob.");
            player = new character("Bob"); // Remove the redundant 'Character' type declaration
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
            if (diceInstance.rollMediumChoice() >= 5) {

                System.out.println("Wizard: Excellent! I knew I could count on you " + player.getName() + ".");
                System.out.println("Wizard: Here is a map to the cave. Good luck!");
                System.out.println("Would you like to head to the South or to the East?");
                String direction = System.console().readLine();
                int directionRoll = diceInstance.rollMediumChoice();

                // choice failures

                // dragon's lair failure
                if (directionRoll == 1) {
                    System.out.println("You have chosen to head" + direction + ".");
                    System.out.println(
                            "Unfortunately along the way you fall through the ground and directly into a DRAGONS LAIR");
                    dragonsLair(player);
                    // TODO: Make dragon's lair

                    // goblin's encounter failure
                } else if (directionRoll == 2) {
                    System.out.println("You have chosen to head" + direction + ".");
                    System.out.println("Somehow along the way you get lost and find yourself surrounded by goblins!");
                    goblinEncounter(player);
                    // make goblin lair

                    // success rolls
                } else if (directionRoll >= 3) {
                    if (direction.equals("south")) {
                        System.out.println("You have chosen to head south.");
                        southMountains(player);
                        // make southMountains

                    } else if (direction.equals("east")) {
                        System.out.println("You have chosen to head east.");
                        eastVillageplayer(player);
                        // make eastVillage
                    } else {
                        System.out.println("I'm sorry, I didn't catch that. Please type 'south' or 'east'.");
                    }
                }

            } else {
                System.out.println("I'm sorry but I've changed my mind " + player.getName() + ".");
                System.out.println("I don't think you are the right person for the job.");
                System.out.println("Goodbye.")
                System.out.println("Good luck in the dragon's lair!");
                dragonsLair(player);
            }
            //test

            // Declines the quest
        } else if (input.equals("no")) {
            
            dice diceInstance = new dice();
            int noAttempt = diceInstance.rollMediumChoice();
            // Decline quest failure
            if (noAttempt <= 5) {
                System.out.println("Wizard: I understand. It is a dangerous task.");
                System.out.println("Wizard: I will find someone else to do it.");
                System.out.println("Wizard: Goodbye.");
                System.exit(0);
            } 
            // Decline quest success
            else {
                System.out.println("Wizard: I'm sorry but you don't have a choice " + player.getName() + ".");
                System.out.println("Wizard: You must accept the quest.");
                System.out.println("Wizard: I will now teleport you to the South Mountains.");
                southMountains(player);
            }
        } else {
            System.out.println("Wizard: I'm sorry, I didn't catch that. Please type 'yes' or 'no'.");
        }

    }
    // test
}
