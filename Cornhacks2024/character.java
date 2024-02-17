package Cornhacks2024;
import java.util.ArrayList;
public class player{
    private String playerName;
    private String playerAttribute;
}
public player(String playerName){
    this.playerName = playerName;
}
public String getName(){
    return this.playerName;
}
public String getAttribute(){
    return this.playerAttribute;
}
public setName(String playerName){
    this.playerName = playerName;
}
public setAttribute(String playerAttribute){
    this.playerAttribute = playerAttribute;
}
public player toString(){
    return ("Name: " + this.playerName + " Attribute: " + this.playerAttribute);
}
