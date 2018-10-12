package com.swcorp.reflection;

import java.lang.reflect.*;
import java.util.*;

/**
 * @author swcorp
 */
public class MethodListHelper {

	/**
	 * Method returns methods metadata
	 * @param aClass class to analyse
	 * @param includeAbstract should we include abstract methods
	 * @param includeSuperclass should we include methods from the class we extend (only direct superclass)
	 * @return collection of methods metadata
	 */
	public Collection<MethodInfo> listMethods(Class aClass, boolean includeAbstract, boolean includeSuperclass) {

		Collection<MethodInfo> arrayList = new ArrayList<>();

		if (!includeAbstract && !includeSuperclass) {
			Method[] methods = aClass.getDeclaredMethods();
			Arrays.stream(methods)
					.forEach(e -> {
						List<Class> args = Arrays.asList(e.getParameterTypes());
						arrayList.add(
								new MethodInfo(e.getName(),
										Modifier.isAbstract(e.getModifiers()),
										args,
										e.getReturnType()));
					});
//		} else if () {
			
		}
		System.out.println("Result!!! :" + arrayList);




		return arrayList;
	}
}
