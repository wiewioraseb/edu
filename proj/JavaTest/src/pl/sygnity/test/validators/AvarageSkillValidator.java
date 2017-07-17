package pl.sygnity.test.validators;

import pl.sygnity.test.util.FieldPlayer;
import pl.sygnity.test.util.Player;
import pl.sygnity.test.validators.utility.Verify;

public class AvarageSkillValidator implements PlayerValidator{

    @Override
    public boolean validate(Player player)  {
            try {
                // TODO: solve mystery how to pass generic class Player.class
                // solution? https://docs.oracle.com/javase/tutorial/reflect/class/classMembers.html
                // change to: Field[] fields = klazz.getFields(); instead of getDeclaredFields()
                return Verify.skillsThreshold(player, Player.class);
            } catch (IllegalAccessException e) {
                e.printStackTrace();
            }
        return false;
    }
}
