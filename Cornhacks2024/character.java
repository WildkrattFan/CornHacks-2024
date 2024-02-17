package Cornhacks2024;

import java.util.ArrayList;

public class character {
    private String playerName;
    private String playerAttribute;
    private ArrayList<String> inventory;

    public character(String playerName) {
        this.playerName = playerName;
        this.inventory = new ArrayList<>();
    }

    public character(String playerName, String playerAttribute) {
        this.playerName = playerName;
        this.playerAttribute = playerAttribute;
        this.inventory = new ArrayList<>();
    }

    public String getName() {
        return this.playerName;
    }

    public String getAttribute() {
        return this.playerAttribute;
    }

    public ArrayList<String> getInventory() {
        return this.inventory;
    }

    public String playerToString() {
        return ("Name: " + playerName + " Attribute: " + this.playerAttribute);
    }
}
