package pl.sygnity.test.util;

import java.util.HashMap;
import java.util.Map;
import java.util.Set;

/* 
 * Klasa reprezentująca piłkarza oraz jego podstawowe dane osobowe
 */
public abstract class Player {

	private String firstName;
	private String lastName;
	private int age;
	
	public Player(String firstName, String lastName, int age) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.age = age;
	}
	
	public String getFirstName() {
		return this.firstName;
	}
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}
	public String getLastName() {
		return this.lastName;
	}
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}
	public int getAge() {
		return this.age;
	}
	public void setAge(int age) {
		this.age = age;
	}

	public String toString() {
		return firstName + " " + lastName + "(" + age + ")";
	}
}
