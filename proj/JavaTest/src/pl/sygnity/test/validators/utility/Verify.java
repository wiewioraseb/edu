package pl.sygnity.test.validators.utility;

import pl.sygnity.test.util.Player;

import java.lang.reflect.Field;
import java.util.ArrayList;
import java.util.List;

public class Verify {
    public static <T> boolean skillsThreshold(Player player, Class<T> klazz) throws IllegalAccessException {
        Field[] fields = klazz.getDeclaredFields();
        List<Integer> skills = new ArrayList<Integer>();
        for (Field field: fields) {
            if (field.getType().equals(Integer.TYPE)) {
                field.setAccessible(true);
                skills.add((Integer)field.get(player));
            }
        }

        return calculateAverage(skills) > 50;
    }

    private static double calculateAverage(List <Integer> skills) {
        Integer sum = 0;
        if(!skills.isEmpty()) {
            for (Integer skill : skills) {
                sum += skill;
            }
            return sum.doubleValue() / skills.size();
        }
        return sum;
    }
}
