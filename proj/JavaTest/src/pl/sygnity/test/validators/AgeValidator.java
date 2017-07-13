package pl.sygnity.test.validators;

import pl.sygnity.test.util.Player;

public class AgeValidator implements PlayerValidator{

    @Override
    public boolean validate(Player player) {
        return player.getAge() < 30;
    }
}
