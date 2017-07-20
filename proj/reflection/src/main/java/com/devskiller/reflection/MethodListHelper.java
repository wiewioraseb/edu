package com.devskiller.reflection;

import java.lang.reflect.*;
import java.util.*;

/**
 * @author Devskiller
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
		throw new UnsupportedOperationException("Please, implement me");
	}
}
