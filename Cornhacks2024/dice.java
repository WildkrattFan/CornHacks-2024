package Cornhacks2024;

import java.util.Random;

public class Dice {
    public int rollEasyChoice() {
        return random.nextInt(5) + 1;

    }

    public int rollMediumChoice() {
        return random.nextInt(10) + 1;
    }

    public int rollHardChoice() {
        return random.nextInt(15) + 1;
    }
}


