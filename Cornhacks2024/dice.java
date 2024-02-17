package Cornhacks2024;

import java.util.Random;

public class dice {
    private Random random = new Random();

    public static int rollEasyChoice() {
        return random.nextInt(5) + 1;
    }

    public static int rollMediumChoice() {
        return random.nextInt(10) + 1;
    }

    public static int rollHardChoice() {
        return random.nextInt(15) + 1;
    }
}
