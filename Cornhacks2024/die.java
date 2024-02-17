package Cornhacks2024;

public class dice {
    private String name;
    private int numSides;

    public dice(String name, int numSides) {
        this.name = name;
        this.numSides = numSides;
    }

    public getName(){
        return this.name;s
    }

    public getNumSides(){
        return this.numSides;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setNumSides(int numSides) {
        this.numSides = numSides;
    }

    public toString toString(){
        return ("Name: " + this.name + " NumSides: " + this.numSide)

    }

}