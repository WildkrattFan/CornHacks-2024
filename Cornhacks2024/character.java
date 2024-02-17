package Cornhacks2024;

public class character {
    private String playerName;
    private String playerAttribute;

    public character(String playerName, String playerAttribute) {
        this.playerName = playerName;
        this.playerAttribute = playerAttribute;
    }

    public String getName() {
        return playerName;
    }

    public String getAttribute() {
        return this.playerAttribute;
    }

    public String toString() {
        return ("Name: " + playerName + " Attribute: " + this.playerAttribute);
    }
}
