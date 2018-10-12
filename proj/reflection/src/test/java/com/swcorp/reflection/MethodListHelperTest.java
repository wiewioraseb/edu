package com.swcorp.reflection;

import java.util.Collection;
import java.util.Collections;
import java.util.List;

import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author swcorp
 */
public class MethodListHelperTest {

	@Test
	public void shouldReturnDeclaredMethods() throws Exception {
		// given
		MethodListHelper methodListHelper = new MethodListHelper();

		// when
		Collection<MethodInfo> methodInfos = methodListHelper.listMethods(SampleRepository.class, false, false);

		// then
		assertThat(methodInfos).containsOnly(
				new MethodInfo("save", false, Collections.singletonList(Object.class), void.class),
				new MethodInfo("find", false, Collections.singletonList(Long.class), Object.class),
				new MethodInfo("findAll", false, Collections.emptyList(), List.class)
		);
	}

	@Test
	public void shouldReturnInheritedAbstractMethod() throws Exception {
		// given
		MethodListHelper methodListHelper = new MethodListHelper();

		// when
		Collection<MethodInfo> methodInfos = methodListHelper.listMethods(SampleRepository.class, true, true);

		// then
		assertThat(methodInfos).containsOnly(
				new MethodInfo("save", false, Collections.singletonList(Object.class), void.class),
				new MethodInfo("find", false, Collections.singletonList(Long.class), Object.class),
				new MethodInfo("findAll", false, Collections.emptyList(), List.class),
				new MethodInfo("countAll", true, Collections.emptyList(), Long.class)
		);
	}
}