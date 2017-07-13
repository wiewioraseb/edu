package pl.sygnity.test;


public class TreeTraversingTest {
	
	// przejście poprzeczne (od lewej do prawej)
	// prawidłowy wynik: 1 2 3 4 5 6 7 8 9
	private static void inOrder(Node<?> tree) {
		// TODO
	}

	// przejście pionowe (od góry do doły)
	// prawidłowy wynik: 5 3 9 2 4 7 1 6 8
	private static void levelOrder(Node<?> tree) {
		// TODO
	}
	
	/*
	 * Proszę nie modyfikować tej metody!
	 */
	public static void wydrukujWynikZadania(Node<Integer> tree) {
		System.out.println("--- TreeTraversingTest - wynik zadania ---");
		inOrder(tree);
		System.out.println();
		levelOrder(tree);
		System.out.println();
	}
	
	public static class Node<T extends Comparable> {
		
		public Node<T> left;
		public Node<T> right;
		public T data;
		
		public Node(T data) {
			this.data = data;
		}
		
		public Node<T> getLeft() {
			return this.left;
		}
		
		public void setLeft(Node<T> left) {
			this.left = left;
		}
		
		public Node<T> getRight() {
			return this.right;
		}
		
		public void setRight(Node<T> right)	{
			this.right = right;
		}
	}
	
	/* 
	 * Metoda tworzy drzewo takie jak na obrazku poniżej: 
		 
					        5
					       / \
					      /   \
					     /     \
					    3       9
					   / \     /
					  2   4   7
					 /       / \
					1       6   8
	 */
	public static Node<Integer> buildTree() {
		Node<Integer> one = new Node<Integer>(1);
		Node<Integer> two = new Node<Integer>(2);
		Node<Integer> three = new Node<Integer>(3);
		Node<Integer> four = new Node<Integer>(4);
		Node<Integer> five = new Node<Integer>(5);
		Node<Integer> six = new Node<Integer>(6);
		Node<Integer> seven = new Node<Integer>(7);
		Node<Integer> eight = new Node<Integer>(8);
		Node<Integer> nine = new Node<Integer>(9);
		
		five.setLeft(three);
		five.setRight(nine);
		three.setLeft(two);
		three.setRight(four);
		two.setLeft(one);
		nine.setLeft(seven);
		seven.setLeft(six);
		seven.setRight(eight);
		
		return five;
	}
}
