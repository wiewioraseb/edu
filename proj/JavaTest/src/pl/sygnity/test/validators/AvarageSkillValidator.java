package pl.sygnity.test.validators;

import pl.sygnity.test.util.FieldPlayer;
import pl.sygnity.test.util.Player;
import pl.sygnity.test.validators.utility.Verify;

public class AvarageSkillValidator implements PlayerValidator{

    @Override
    public boolean validate(Player player)  {
        if (player instanceof FieldPlayer) {
            try {
                return Verify.skillsThreshold(player, FieldPlayer.class);
            } catch (IllegalAccessException e) {
                e.printStackTrace();
            }
        }
        return false;
    }
}
