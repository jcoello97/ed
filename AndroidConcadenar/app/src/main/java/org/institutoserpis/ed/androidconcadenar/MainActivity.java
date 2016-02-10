package org.institutoserpis.ed.androidconcadenar;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity
{
    private EditText editText1, editText2;
    private TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void onClickAddButton(View view)
    {
        editText1=(EditText)findViewById(R.id.Primer);
        editText2=(EditText)findViewById(R.id.Segundo);

        String cadena1= editText1.getText().toString();
        String cadena2=editText2.getText().toString();

        textView=(TextView)findViewById(R.id.Mensaje);

        textView.setText(cadena1 + "\n***************\n" + cadena2);
    }
}
