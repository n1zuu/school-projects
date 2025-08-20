public class InfixPostfix {
    private MyStack stack;

    public InfixPostfix(String exp) {
        stack = new ShitStack();

        convert(exp);
        
    }

    public void display() {
        stack.displayAll();
    }

    private void convert(String in) {
        char curr;
        Stack temp = new Stack();

        for (int i = 0; i < in.length(); ++i) {
            curr = in.charAt(i);
            
            if (isAlphaNumeric(in.charAt(i))) {
                stack.push(in.charAt(i));
            } else if (in.charAt(i) == '(') {
                temp.push(in.charAt(i));
            } else if (in.charAt(i) == ')') { // Push elements into final stack until ')' is encountered
                while (!temp.isEmpty() && temp.peek() != '(') {
                    stack.push(temp.pop());
                }
                temp.pop();
            } else if (in.charAt(i) == ' ') {
               continue;
            } else { // If operator is found push elements into final stack until top is of lower or equal precedence
               while (!temp.isEmpty() && (checkPrecedence(curr) <= checkPrecedence(temp.peek()))) {
                  stack.push(temp.pop());
               }
               temp.push(curr);
            }
         }
         while (!temp.isEmpty()) { // Push rest into final stack
            stack.push(temp.pop());
         }

         temp = null; // Deallocate temp stack
    }
    /*
     *  Precedence checker for operators
     *  Lower precedence values are prioritized
     */
    private static int checkPrecedence(char c) {
        switch (c) {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                return 0; // Base condition(if character is not an operator)
        }
    }
    private static double returnResult (Stack st) {
                  
    }
}