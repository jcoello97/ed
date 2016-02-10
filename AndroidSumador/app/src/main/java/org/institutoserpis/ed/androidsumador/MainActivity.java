package org.institutoserpis.ed.androidsumador;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.math.BigDecimal;

public class MainActivity extends AppCompatActivity
{
    private EditText editText1, editText2;
    private BigDecimal bigDecimal1, bigDecimal2, resultado;
    private TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void onClickSumarButton(View view)
    {
        editText1=(EditText)findViewById(R.id.Primer);
        String cadena1=editText1.getText().toString();
        bigDecimal1=new BigDecimal(cadena1);


        editText2=(EditText)findViewById(R.id.Segundo);
        String cadena2=editText2.getText().toString();
        bigDecimal2=new BigDecimal(cadena2);

        resultado=bigDecimal1.add(bigDecimal2);
        textView=(TextView)findViewById(R.id.Mensaje);
        textView.setText(resultado.toString());
    }
}
