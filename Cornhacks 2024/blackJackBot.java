
public class blackJackBot {
    public static void botAnalysis() {
        
        if(game.cardsValue(game.playerHand) >= 17){
            game.suggestStand();
        }
        else if(game.cardsValue(game.platerHand) <= 16){
            checkDealerHand();
        }

        private static void checkDealerHand(){
            if(game.cardsValue(game.dealerUpCard) <= 6){
                game.suggestHit();
            }
            else if(game.cardsValue(game.dealerHand) > 6){
                game.suggestStand();
            }
        }

    }
