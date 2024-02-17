package Cornhacks2024;

public class Item {

    private String name;
    private String description;
    private int value;
    private int damage;

    public Item(String name, String description, int value, int damage) {
        this.name = name;
        this.description = description;
        this.value = value;
        this.damage = damage;
    }

    public Item(String name, String description, int value) {
        this.name = name;
        this.description = description;
        this.value = value;
    }

    public String getName() {
        return this.name;
    }

    public String getDescription() {
        return this.description;
    }

    public int getValue() {
        return this.value;
    }

    public int getDamage() {
        return this.damage;
    }

    public String ItemToString() {
        return ("Name: " + this.name + " Description: " + this.description + " Value: " + this.value);
    }

}
