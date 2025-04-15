# BlueMall Puntacana Transportation Reservation Chatbot Flow

## Initial Greeting
```
¡Gracias por elegir BlueMall Puntacana como su destino de compras! Servirle es nuestra prioridad, así que déjenos sus datos para procesar su reserva de transporte, para que nuestro equipo pueda brindarle un mejor servicio. Este chat es exclusivo para reservas de traslado desde los hoteles hacia el Mall.
```

## Language Selection
```
Elija su idioma:
- Español
- Inglés
- Francés
- Ruso
- Portugués
- Chino Mandarín
```

## Customer Type
```
¿Es usted un cliente directo, referidor con código o nuevo referidor?
- Cliente directo
- Referidor con código
- Nuevo referidor
- Otro (especifique)
```

### If "Cliente directo" is selected:
```
Indique la fecha en que desea realizar sus compras:
[Calendar/Date Format]
```

### If "Referidor con código" is selected:
```
Estimado referidor, por favor escribir su código:
[Text input for code]

Gracias. Indique la fecha en que desea la reserva para sus clientes:
[Calendar/Date Format]
```

### If "Nuevo referidor" is selected:
```
Gracias por su interés en ser referidor nuestro, para crear su código debe enviarnos los siguientes datos:

- Envíe una foto de su cedula
- Hotel, si trabaja en un hotel o Compañía, si es un representante
- Nombre y apellido
- Teléfono
- Fecha de cumpleaños
- Cargo
- Tipo de pago:
  - Depósito
  - Efectivo

If "Depósito" is selected:
  - Banco
  - Tipo de cuenta
  - Número de cuenta

Gracias, uno de nuestros comerciales le estará enviando su código y demás detalles.

Indique la fecha en que desea la reserva para sus clientes:
[Calendar/Date Format]
```

## Hotel Location
```
Elija la zona en la que se encuentra su hotel:
- Bávaro
- Punta Cana
- Cap Cana
- Cabeza de Toro
- Uvero Alto
- Bayahíbe
- La Romana
- No lo sé (Si marca esto se le pide que escriba el nombre de su hotel)
```

## Hotel Selection
Based on the zone selected, display corresponding hotels:

### If "Cap Cana" is selected:
```
Elija su hotel:
- Secret Cap Cana
- Hyatt Ziva
- Hyatt Zilara
- Santuary Cap Cana
- Margaritaville Island
- Tortuga Bay
- Eden Roc Cap Cana
- Sports Illustrated
- Trs Cap Cana
- No está en la lista (Si marca este se le pide que escriba el nombre de su hotel)
```

### If "Bávaro" is selected:
```
Elija su hotel:
- Hard Rock Hotel
- Riú República
- Occidental Caribe
- Royalton Punta Cana
- Royalton Bávaro
- Memories Splash
- Majestic Elegance
- Majestic Miraje
- Majestic Colonial
- Complejo Bahía Príncipe
- Riú Punta Cana
- Riú Bambú
- Riú Macao
- Riú Bávaro
- Iberostar Bávaro
- Iberostar Dominicana
- Iberostar Punta Cana
- Iberostar Grand
- Whala Urban Punta Cana
- Palladium Bávaro
- Palladium TRS Turquesa
- Palladium Punta Cana
- Palladium Palace
- Ocean Blue and Sand
- Vick Arena Blanca
- Punta Cana Princess
- Bávaro Princess
- Caribe Deluxe Princess
- Occidental Punta Cana
- Grean Coast Beach
- Vista Sol Punta Cana
- Whala Bávaro
- Paradisus Palma Real
- Paradisus Grand Cana
- Meliá Punta Cana Beach
- Meliá Caribe Beach
- Secrets Royal Beach
- Dreams Royal Beach
- Dreams Royal Beach (Preferred)
- Barceló Bavaro Palace
- Lopesan Costa Bávaro
- No está en la lista (Si marca este se le pide que escriba el nombre de su hotel)
```

### If "Uvero Alto" is selected:
```
Elija su hotel:
- Zoetry Agua
- Sivory
- Excellence del Carmen
- Excellence Punta Cana
- Secrets Tides Punta Cana
- Breathless Punta Cana
- Dreams Onyx Punta Cana
- Live Aqua
- Jewel Punta Cana
- Nickelodeon
- Royalton Chic
- Ocean el Faro
- Dreams Macao
- No está en la lista (Si marca este se le pide que escriba el nombre de su hotel)
```

### If "Bayahibe" is selected:
```
Elija su hotel:
- Iberostar Hacienda
- Catalonia Bayahibe
- Dreams Dominicus
- Viva Dominicus Palace
- Viva Wyndham Dominicus Beach
- No está en la lista (Si marca este se le pide que escriba el nombre de su hotel)
```

## Service Options
The system checks the hotel and displays the appropriate service options:

### If hotel has free shuttle service (example: Secret Cap Cana):
```
Para su hotel Secret Cap Cana tenemos el servicio de traslado gratuito en nuestras rutas fijas con una duración de 2 horas en el Mall. El bus pasa en los siguientes horarios, elija el de su preferencia:
- 9:25 am
- 2:35 pm
- Lo voy a analizar y escribiré luego.
```

### If hotel requires VIP service in Bávaro (example: Iberostar Bávaro):
```
Para su hotel Iberostar Bávaro no tenemos el servicio de traslado gratuito, pero le podemos ofrecer nuestro servicio VIP, con una duración de 2 horas en el Mall. Nuestras reservas VIP tienen un costo general de 20 USD$ por un mínimo de 4 personas. En caso de que vengan menos de 4, pagan el total de 4 como monto mínimo. A partir de 4 personas se cobrará 5 USD$ por cada persona adicional que se agregue. Esto les cubre ida y vuelta.

¿Desea nuestro servicio VIP?
- Si, por favor.
- Lo voy a analizar y escribiré luego.
```

### If hotel requires VIP service in Uvero Alto (example: Ocean el Faro):
```
Para su hotel Ocean el Faro no tenemos el servicio de traslado gratuito, pero le podemos ofrecer nuestro servicio VIP, con una duración de 2 horas en el Mall. Nuestras reservas VIP tienen un costo general de 40 USD$ por un mínimo de 4 personas. En caso de que vengan menos de 4, pagan el total de 4 como monto mínimo. A partir de 4 personas se cobrará 10 USD$ por cada persona adicional que se agregue. Esto les cubre ida y vuelta.

¿Desea nuestro servicio VIP?
- Si, por favor.
- Lo voy a analizar y escribiré luego.
```

### If hotel is in Bayahibe (example: Catalonia Bayahibe):
```
Para su hotel Catalonia Bayahibe no tenemos servicio gratis en esa zona, por la distancia, pero podemos coordinar y ofrecerle nuestro servicio VIP, el cual tiene un costo mínimo. El costo dependerá de la cantidad de personas. Esto les cubre ida y vuelta.

¿Desea nuestro servicio VIP?
- Si, por favor.
- Lo voy a analizar y escribiré luego.

If "Si, por favor" is selected:
Elija la cantidad de personas:
- Menos de 15 personas: El costo del servicio es de 15 US$ por persona (le cubre ida y vuelta), pero deben ser un mínimo de 13, si son menos, deberán pagar el valor total de los 13, que son 195 US$. La capacidad del bus es de 15 personas.
- Más de 15 personas: El costo del servicio es de 15 US$ por persona (le cubre ida y vuelta), pero deben ser un mínimo de 22, si son menos, deberán pagar el valor total de los 22, que son 330 US$. La capacidad del bus es de 30 personas.
```

### If "Lo voy a analizar y escribiré luego" is selected:
```
[Message encouraging user to make reservation later]
```

## Schedule Selection (if service was accepted)
```
Elija el horario de su preferencia:
[Display available times based on the selected hotel and date]
```

## Customer Information
For direct clients:
```
- Indique su nombre completo
- Indique su número de habitación
- Indique la cantidad de adultos
- Indique la cantidad de niños
- Indique su número de teléfono
- Indique su E-Mail
```

For referrers:
```
- Indique el nombre del cliente
- Indique el número de habitación
- Indique la cantidad de adultos
- Indique la cantidad de niños
- Indique su número de teléfono
- Indique su E-Mail
```

## Confirmation Message
Example for free shuttle service:
```
¡Reserva confirmada para el [día de la semana] [fecha] a las [hora]! Su punto de encuentro será en el Lobby del Hotel. Por favor estar puntual.
```

Example for VIP service:
```
¡Reserva confirmada para el [día de la semana] [fecha] a las [hora]! Su punto de encuentro será en el Lobby del Hotel. Por favor estar puntual. Realizará el pago del servicio a la llegada al Mall.
```

Example for referrer VIP service:
```
¡Reserva confirmada para el [día de la semana] [fecha] a las [hora]! Su punto de encuentro será en el Lobby del Hotel. Por favor estar puntual. Su cliente realizará el pago del servicio a la llegada al Mall.
```