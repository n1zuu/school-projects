/*
 * Calculator Program
 * Author: Tapdasan, Vince Jevy B.
*/

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Calculator extends JFrame implements ActionListener {
   String[] btnLabels = {
      "1", "2", "3", "*",
      "4", "5", "6", "/",
      "7", "8", "9", "+",
      "AC", "0", "=", "-",
   };
   JButton[] btns = new JButton[btnLabels.length];
   JPanel keypad = new JPanel(new GridLayout(4,4));
   JTextField txtResult = new JTextField("0");
   
   public Calculator(){
      setSize(500, 500);
      setLocationRelativeTo(null);
      setTitle("Calculator");
      setResizable(false);
      setDefaultCloseOperation(EXIT_ON_CLOSE);
      setLayout(new BorderLayout());
      
      // Add text field
      txtResult.setFont(new Font("Verdana", Font.PLAIN, 32));
      txtResult.setHorizontalAlignment(SwingConstants.RIGHT);
      txtResult.setMargin(new Insets(10, 10, 10, 10));
      txtResult.setBackground(Color.BLUE);
      txtResult.setForeground(Color.WHITE);
      add(txtResult, BorderLayout.NORTH);
      
      // Add btns
      for(int i = 0; i < btnLabels.length; i++) {
         btns[i] = new JButton(btnLabels[i]);
         if(btnLabels[i].equals("AC")) {
            btns[i].setForeground(Color.WHITE);
            btns[i].setBackground(Color.RED);
         }
         btns[i].addActionListener(this);
         btns[i].setFont(new Font("Verdana", Font.PLAIN, 28));
         keypad.add(btns[i]);
      }
      add(keypad, BorderLayout.CENTER);
      
      setVisible(true);
   }
   
   public void actionPerformed(ActionEvent e) {
      String event = e.getActionCommand();
      String result = txtResult.getText();
      
      switch(event) {
         case "1": case "2": case "3":
         case "4": case "5": case "6":
         case "7": case "8": case "9":
            if (result.equals("0")) 
               result = event;
            else 
               result += event;
            break;
         case "AC":
            result = "0";
            break;
         case "0":
            if (result.startsWith("0")) 
               break;
            else
               result += event;                
            break;
         case "+": case "-": case "*": case "/":
            if (result.charAt(result.length() - 1) == '+' || result.charAt(result.length() - 1) == '-' 
            || result.charAt(result.length() - 1) == '*' || result.charAt(result.length() - 1) == '/')
               break;
            else 
               result += event;
            break;
         case "=":
            break;
         // compute
      }
      txtResult.setText(result);
   }
   
   public static void main(String ...args) {
      try {      
         new Calculator();
      } catch (Exception e) {
         System.out.println(e);
      }
   }
} // EOC