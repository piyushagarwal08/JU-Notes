import javax.swing.*;  
    import java.awt.event.*;
    import java.awt.*;

    class Main implements AdjustmentListener {

        private static void createAndShowGUI() {
            // make frame..
          JFrame frame = new JFrame("JScrollBar");
          frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
          frame.setBounds(20,30,200,250);
          frame.getContentPane().setLayout(null);
          Main app = new Main();
          app.sbar1 = new JScrollBar(java.awt.Adjustable.VERTICAL, 127, 1,0,255);
          app.sbar1.setBounds(10,20, 10, 200);
          app.sbar1.setBackground(Color.red);
          app.sbar1.addAdjustmentListener(app);
          frame.getContentPane().add(app.sbar1);
          app.sbar2 = new JScrollBar(java.awt.Adjustable.VERTICAL, 127, 1,0,255);
          app.sbar2.setBounds(30,20, 10, 200);
          app.sbar2.setBackground(Color.green);
          app.sbar2.addAdjustmentListener(app);
          frame.getContentPane().add(app.sbar2);
          app.sbar3 = new JScrollBar(java.awt.Adjustable.VERTICAL, 127, 1,0,255);
          app.sbar3.setBounds(50,20, 10, 200);
          app.sbar3.setBackground(Color.blue);
          app.sbar3.addAdjustmentListener(app);
          frame.getContentPane().add(app.sbar3);

          app.panel = new JPanel();
          app.panel.setBounds(80,20,50,200);
          app.panel.setBackground(new Color(0,0,0));
          frame.getContentPane().add(app.panel);

          frame.setVisible(true); 
      }

      public void adjustmentValueChanged(AdjustmentEvent e)
      {
          panel.setBackground(new Color(sbar1.getValue(),sbar2.getValue(), sbar3.getValue()));
      }

      public static void main(String[] args) {
        // start off..
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                createAndShowGUI();
            }
        });
      }

      // application object fields    
      JScrollBar sbar1;
      JScrollBar sbar2;
      JScrollBar sbar3;
      JPanel panel;
}