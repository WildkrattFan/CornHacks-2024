package Cornhacks2024;

import java.util.ArrayList;

public class character {
    private String playerName;
    private String playerAttribute;
    private ArrayList<String> inventory;
    private int healthBar;

    public character(String playerName) {
        this.playerName = playerName;
        this.inventory = new ArrayList<>();
        this.healthBar = 100;
    }

    public String getName() {
        return this.playerName;
    }

    public ArrayList<String> getInventory() {
        return this.inventory;
    }

    public int getHealthBar() {
        return this.healthBar;
    }

    public void addInventoryItem(String item) {
        this.inventory.add(item);
    }

    public String playerToString() {
        return ("Name: " + playerName + " Attribute: " + this.playerAttribute);
    }
}
