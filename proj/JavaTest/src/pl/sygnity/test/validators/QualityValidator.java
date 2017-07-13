package pl.sygnity.test.validators;


import pl.sygnity.test.util.Player;

public class QualityValidator implements PlayerValidator{

    @Override
    public boolean validate(Player player) {
        return true;
    }
}
