package pl.sygnity.test.validators;

import pl.sygnity.test.util.FieldPlayer;
import pl.sygnity.test.util.Player;

import java.lang.reflect.Field;

public class AvarageSkillValidator implements PlayerValidator{

    @Override
    public boolean validate(Player player) {
        if (player instanceof FieldPlayer) {
            inspect(FieldPlayer.class);
            return true;
        }
        return false;
    }

    public <T> void inspect(Class<T> klazz) {
        Field[] fields = klazz.getDeclaredFields();
        for (Field field: fields) {
            System.out.println(field.toString());
        }
    }
}
