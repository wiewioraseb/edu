package pl.sygnity.test.validators;


import pl.sygnity.test.util.FieldPlayer;
import pl.sygnity.test.util.GoalKeeper;
import pl.sygnity.test.util.Player;
import pl.sygnity.test.util.Striker;

public class QualityValidator implements PlayerValidator{

    @Override
    public boolean validate(Player player) {
        if (player instanceof GoalKeeper) {
            return ( ((GoalKeeper) player).getHandling() > 70 && (((GoalKeeper) player).getAerialAbility() > 70));
        } else if (player instanceof FieldPlayer) {
            if ( ((FieldPlayer) player).getPassing() > 50 && (((FieldPlayer) player).getTechnique() > 50) ) {
                if (player instanceof Striker) {
                    return ( ((Striker) player).getFinishing() > 80 && (((Striker) player).getTechnique() > 50));
                } else {
                    return true;
                }
            }
        }
        return false;
    }
}
