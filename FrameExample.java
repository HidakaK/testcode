import javax.swing.*;
import java.awt.*;
public class FrameSample extends JFrame{
private static void createAndShow(){
FrameSample frame=new FrameSample();
frame.setDefaultCloseOperation(EXIT_ON_CLOSE);
frame.setSize(640,480);
frame.setTitle("Javaタイトル");
/*frame.add("North",new JButton("North"));
frame.add("West",new JButton("West"));
frame.add("Center",new JButton("Center"));
frame.add("East",new JButton("East"));
frame.add("South",new JButton("South"));*/
JPanel drawingPanel=new JPanel();
drawingPanel.setBackground(Color.WHITE);
frame.add("Center",drawingPanel);
frame.add("East",new JPanel());
frame.setVisible(true);
}
public static void main(String[]args){
SwingUtilities.invokeLater(()->{createAndShow();});
}
}