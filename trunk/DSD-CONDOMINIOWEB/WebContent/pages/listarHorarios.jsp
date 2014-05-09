<%int cod = Integer.parseInt(request.getParameter("ec"));
String estado;
 switch(cod) {
 case 1: estado="";
     break;
 case 2:estado="";
     break;
 case 3:estado="";
     break;
 case 4:estado="disabled";
     break;
 case 5: 
 case 6:estado="";
     break;
 default:estado="disabled";
     break;
 } 
 
 %>
		<tr>
		<td width="30">
			<input id="fc_horario1" type="radio" name="fc_horario" value="8:00 - 9:00" <%=estado %> required="required"> 8:00 - 9:00
		</td>
        <td></td>
        </tr>
        <tr>
		<td width="10">
			<input id="fc_horario2" type="radio" name="fc_horario" value="9:00 - 10:00" <%=estado %> required="required"> 9:00 - 10:00
		</td>
        <td></td>
        </tr>
        <tr>
		<td width="10">
			<input id="fc_horario3" type="radio" name="fc_horario" value="10:00 - 11:00"  <%=estado %> required="required"> 10:00 - 11:00
		</td>
        <td></td>
        </tr>
        <tr>
		<td width="10">
			<input id="fc_horario4" type="radio" name="fc_horario" value="11:00 - 12:00"  <%=estado %> required="required"> 11:00 - 12:00
		</td>
        <td></td>
        </tr>
         <tr>
		<td width="10">
			<input id="fc_horario4" type="radio" name="fc_horario" value="12:00 - 13:00"  <%=estado %> required="required"> 12:00 - 13:00
		</td>
        <td></td>
        </tr>
         <tr>
		<td width="10">
			<input id="fc_horario4" type="radio" name="fc_horario" value="13:00 - 14:00"  <%=estado %> required="required"> 13:00 - 14:00
		</td>
        <td></td>
        </tr>
          <tr>
		<td width="10">
			<input id="fc_horario4" type="radio" name="fc_horario" value="14:00 - 15:00"  <%=estado %> required="required"> 14:00 - 15:00
		</td>
        <td></td>
        </tr>
         <tr>
		<td width="10">
			<input id="fc_horario4" type="radio" name="fc_horario" value="15:00 - 16:00"  <%=estado %> required="required"> 15:00 - 16:00
		</td>
        <td></td>
        </tr>
         <tr>
		<td width="10">
			<input id="fc_horario4" type="radio" name="fc_horario" value="16:00 - 17:00"  <%=estado %> required="required"> 16:00 - 17:00
		</td>
        <td></td>
        </tr>
          <tr>
		<td width="10">
			<input id="fc_horario4" type="radio" name="fc_horario" value="17:00 - 18:00"  <%=estado %> required="required"> 17:00 - 18:00
		</td>
        <td></td>
        </tr>

