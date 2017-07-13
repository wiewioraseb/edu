package pl.sygnity.test;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import pl.sygnity.test.util.FieldPlayer;
import pl.sygnity.test.util.GoalKeeper;
import pl.sygnity.test.util.Player;
import pl.sygnity.test.util.Striker;
import pl.sygnity.test.validators.AgeValidator;
import pl.sygnity.test.validators.AvarageSkillValidator;
import pl.sygnity.test.validators.PlayerValidator;
import pl.sygnity.test.validators.QualityValidator;

public class InheritanceTest {

	/* 
	 * Baza wszystkich zawodników
	 */
	private static List<Player> players;
	
	/* 
	 * Kolekcja zawodników, którzy pomyślnie prześli wszystkie testy.
	 */
	private static List<GoalKeeper> acceptedGoalKeepers;
	private static List<FieldPlayer> acceptedFieldPlayers;
	private static List<Striker> acceptedStrikers;
	
	/*
	 * Mapa zawodników, którze oblali jeden lub więcej testów.
	 * Klucz - zawodnik, wartość - ilość oblanych testów
	 */
	private static Map<Player, Integer> rejectedPlayers;




	/* 
	 * W tej metodzie należy umieścić instancję każdego z walidatorów w kolekcji(dowolnego typu) oraz zwalidować wszystkich piłkarzy 
	 * używając każdego z walidatorów po kolei. Zawodnicy, którzy zostaną pomyślnie zwalidowali, powinni być umieszczeni w
	 * kolekcjach acceptedKeepers, acceptedFieldPlayers oraz acceptedStrikers w zależności od ich pozycji. 
	 * Wszyscy odrzuceni zawodnicy powinni trafić do mapy rejectedPlayers, gdzie kluczem jest obiekt Player, a wartością ilość oblanych testów.
	 */
	public static void testPlayers() {
		acceptedGoalKeepers = new ArrayList<GoalKeeper>();
		acceptedFieldPlayers = new ArrayList<FieldPlayer>();
		acceptedStrikers = new ArrayList<Striker>();

		PlayerValidator ageValidator = new AgeValidator();
		PlayerValidator avarageSkillValidator = new AvarageSkillValidator();
		PlayerValidator qualityValidator = new QualityValidator();
		for (Player player : players) {
			if (ageValidator.validate(player)
					&& avarageSkillValidator.validate(player)
					&& qualityValidator.validate(player)) {
				if (player instanceof FieldPlayer) acceptedFieldPlayers.add((FieldPlayer)player);
				if (player instanceof GoalKeeper) acceptedGoalKeepers.add((GoalKeeper)player);
				if (player instanceof Striker) acceptedStrikers.add((Striker)player);
			}
		}

		// TODO
	}		
	
	/* 
	 * Metoda tworzy bazę zawodników.
	 * Proszę nie modyfikować tej metody!
	 */
	public static void createPlayerBase() {
		players = new ArrayList<Player>();
		
		players.add(new GoalKeeper("Artur", "Borubar", 29, 95, 75));
		players.add(new GoalKeeper("Wojtek", "Papierosek", 23, 75, 70));
		players.add(new GoalKeeper("Paweł", "Mariuszek", 32, 55, 45));
		players.add(new FieldPlayer("Jakub", "Warzywniak", 31, 60, 50, 60, 80));
		players.add(new FieldPlayer("Kamil", "Plik", 22, 60, 51, 40, 90));
		players.add(new FieldPlayer("Jakub", "Rzeźnik", 28, 10, 20, 70, 100));
		players.add(new FieldPlayer("Kuba", "Biletowy", 27, 80, 65, 80, 60));
		players.add(new FieldPlayer("Kamil", "Kasynowy", 25, 55, 55, 45, 40));
		players.add(new FieldPlayer("Tomasz", "Sosnowiec", 27, 0, 0, 10, 30));
		players.add(new Striker("Robert", "Prawondowski", 26, 80, 90, 50, 70, 80));
		players.add(new Striker("Arkadiusz", "Milimili", 24, 50, 75, 85, 85, 80));
		players.add(new Striker("Leo", "Messi", 29, 100, 100, 95, 95, 100));
		
		Collections.shuffle(players);
	}
		
	/*
	 * Proszę nie modyfikować tej metody!
	 */
	public static void wydrukujWynikZadania() {
		System.out.println();
		System.out.println("--- InheritanceTest - wynik zadania ---");
		System.out.println("Baza zawodników:");
		printArrayList(players);
		System.out.println();
		System.out.println("Zaakceptowani bramkarze:");
		printArrayList(acceptedGoalKeepers);
		System.out.println();
		System.out.println("Zaakceptowani zawodnicy z pola:");
		printArrayList(acceptedFieldPlayers);
		System.out.println();
		System.out.println("Zaakceptowani napastnicy:");
		printArrayList(acceptedStrikers);
		
		System.out.println();
		System.out.println("Odrzuceni zawodnicy:");
		printMap(rejectedPlayers);
	}
	
	/*
	 * Proszę nie modyfikować tej metody!
	 */
	private static <T extends Player> void printArrayList(List<T> players) {
		if (players != null) {
			for (Player player : players) {
				System.out.println(player);
			}
		}
	}
	
	/*
	 * Proszę nie modyfikować tej metody!
	 */
	private static <T extends Player> void printMap(Map<T, Integer> players) {
		if (players != null) {
			Iterator<T> iterator = players.keySet().iterator();
			while (iterator.hasNext()) {
				T player = iterator.next();
				System.out.println(player + " oblane testy: " + players.get(player));
			}
		}
	}
}
