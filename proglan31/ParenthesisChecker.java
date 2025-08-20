/*
 * Write a parenthesis checker that reads from a file "test.txt"
 * Return 'okay' if properly balanced, else 'not okay'.
 * 
 * Author: Vince Jevy Tapdasan 
 * Date Written: Aug. 20, 2025
 */
import java.io.File;
import java.util.*; 

class Node {
    Node previous;
    char data;
    Node next;

    public Node(char data) {
        this.data = data;
    }
}

class WeirdStack {
    private Node tail;
    public Node head;

    public boolean push(char c) {
        Node newNode = new Node(c);
        newNode.previous = null;
        newNode.next = null;

        if (head == null) {
            head = tail = newNode;
        } else {
            newNode.previous = tail;
            tail.next = newNode;
            tail = tail.next;
        }
        return true;
    }

    public char pop() {
        char data;
        if (isEmpty()) {
            return '\0';
        }
        data = peek();
        if (head == tail) {
            head = tail = null;
        } else {
            tail = tail.previous;
        }
        if (tail != null) { // Null check to prevent NullPointerExceptions
            tail.next = null;
        }
        return data;
    }

    public char peek() {
        if (isEmpty()) {
            return '\0'; // Returns null byte character to prevent reading from null
        }
        return tail.data;
    }

    public boolean isEmpty() {
        return tail == null;
    }

    public void displayAll() {
        Node curr = head;

        while (curr != null) {
            System.out.print(curr.data);
            curr = curr.next;
        }
        System.out.println();
    }
}
 
public class ParenthesisChecker {
    private WeirdStack stack;

    public ParenthesisChecker() {
        stack = new WeirdStack();
    }

    public boolean check(String str) {
        for (int i = 0; i < str.length(); i++) {
            if (stack.isEmpty()) {
                stack.push(str.charAt(i));
            } else if ((stack.peek() == '(') && (str.charAt(i) == ')') || 
                       (stack.peek() == '{') && (str.charAt(i) == '}') || 
                       (stack.peek() == '[') && (str.charAt(i) == ']') ||
                       (stack.peek() == '<') && (str.charAt(i) == '>')) {
                stack.pop();
            } else {
                stack.push(str.charAt(i));
            }
        }
        return stack.isEmpty();
    }
    
    public static void main(String ...args) {
       
       try {
         ParenthesisChecker pc = new ParenthesisChecker();
         File myObj = new File("test.txt");
         Scanner myReader = new Scanner(myObj);
         
         while (myReader.hasNextLine()) {
            String data = myReader.nextLine();
         boolean isOkay = pc.check(data);
         if (isOkay)
            System.out.println(data + " - Okay");
         else 
            System.out.println(data + " - Not Okay");           
         }
         myReader.close();         
       } catch(Exception e){
         // Add exception message someday
       }
   }
}