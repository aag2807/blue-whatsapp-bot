# BlueMall Puntacana WhatsApp Chatbot - Conversation Flow

## Current Implementation Status

**Note**: This document reflects the **actual implemented conversation flow** in the WhatsApp chatbot. Only **direct client flows** are currently implemented. Referral flows are **NOT implemented** and should not be expected to work.

---

## Flow Overview

The chatbot handles transportation reservations from hotels to BlueMall Puntacana. All users are treated as **direct clients** and the flow automatically proceeds without client type selection.

### Main Flow Steps:
1. **Welcome** → Language Selection
2. **Language Selection** → Date Selection (assumes direct client)
3. **Date Selection** → Zone Selection
4. **Zone Selection** → Hotel Selection
5. **Hotel Selection** → Schedule Selection (Free) OR VIP Service Offer
6. **Schedule/VIP Confirmation** → User Information Collection
7. **User Information Collection** → Reservation Confirmation

---

## Scenario #1: Free Service Hotel (e.g., Cap Cana Hotels)

### 1. Welcome Message
```
¡Gracias por elegir BlueMall Puntacana como su destino de compras!
Servirle es nuestra prioridad, así que déjenos sus datos para procesar su reserva de transporte, para que nuestro equipo pueda brindarle un mejor servicio. Este chat es exclusivo para reservas de traslado desde los hoteles hacia el Mall.
```

### 2. Language Selection
**Elija su idioma:**
- **Español** (1)
- **English** (2) 
- **Français** (3)
- **Русский** (4)
- **Português** (5)
- **中文** (6)

*Note: Client type selection is skipped - all users are treated as direct clients.*

### 3. Date Selection
**Indique la fecha en que desea realizar sus compras:**
- Accepts various date formats (DD/MM/YYYY, DD-MM-YYYY, "mañana", "today", etc.)
- Example: "25 de agosto" or "25/08/2024"

### 4. Zone Selection
**Elija la zona en la que se encuentra su hotel:**
- **Bávaro** (1)
- **Punta Cana** (2)
- **Cap Cana** (3)
- **Cabeza de Toro** (4)
- **Uvero Alto** (5)
- **Bayahíbe** (6)
- **La Romana** (7)
- **No lo sé** (8) - If selected, asks for hotel name for fuzzy matching

### 5. Hotel Selection
Shows hotels for the selected zone. Example for **Cap Cana**:
- **Secret Cap Cana** (1)
- **Hyatt Ziva** (2)
- **Hyatt Zilara** (3)
- **Sanctuary Cap Cana** (4)
- **Margaritaville Island** (5)
- **Tortuga Bay** (6)
- **Eden Roc Cap Cana** (7)
- **Sports Illustrated** (8)
- **TRS Cap Cana** (9)
- **No está en la lista** (10) - Asks for hotel name

### 6. Schedule Selection (Free Service)
```
Para su hotel [HOTEL NAME] tenemos el servicio de traslado gratuito en nuestras rutas fijas con una duración de 2 horas en el Mall. El bus pasa en los siguientes horarios, elija el de su preferencia:
```
- Shows available schedules (e.g., **9:25 am**, **2:35 pm**)
- **Lo voy a analizar y escribiré luego** - Ends conversation with reminder

### 7. User Information Collection
**The system collects information in this exact order:**

#### 7.1 Full Name
- **Indique su nombre completo**
- Validates minimum length (2+ characters)

#### 7.2 Room Number  
- **Indique su número de habitación**
- Accepts alphanumeric (e.g., "101", "A1B", "Presidential Suite")

#### 7.3 Adults Count
- **Indique la cantidad de adultos**
- Validates range: 1-50 adults

#### 7.4 Children Count
- **Indique la cantidad de niños**  
- Validates range: 0-20 children

#### 7.5 Phone Number
- **Indique su número de teléfono**
- Accepts various formats with separators (spaces, dashes, dots, parentheses)
- Minimum 7 digits, maximum 15 digits

#### 7.6 Email Address
- **Indique su E-Mail**
- Validates email format with proper regex

### 8. Reservation Confirmation
```
¡Reserva confirmada para el [DAY] [DATE] a las [TIME]!
Su punto de encuentro será en el Lobby del Hotel. Por favor estar puntual.
```

---

## Scenario #2: VIP Service Hotel (e.g., Bávaro, Uvero Alto)

### Steps 1-5: Same as Free Service

### 6. VIP Service Offer
```
Para su hotel [HOTEL NAME] no tenemos el servicio de traslado gratuito, pero le podemos ofrecer nuestro servicio VIP, con una duración de 2 horas en el Mall.

Nuestras reservas VIP tienen un costo de:
- [ZONE PRICING] por un mínimo de 4 personas
- En caso de que vengan menos de 4, pagan el total de 4 como monto mínimo  
- A partir de 4 personas se cobrará [ADDITIONAL_COST] por cada persona adicional
- Esto les cubre ida y vuelta
```

**¿Desea nuestro servicio VIP?**
- **Sí** (proceeds to schedule selection)
- **No** / **Lo voy a analizar** (ends conversation)

### 7. Schedule Selection (VIP)
Shows available VIP schedules for the selected date.

### 8. User Information Collection
Same 6-step process as free service (Name → Room → Adults → Children → Phone → Email)

### 9. Reservation Confirmation  
```
¡Reserva confirmada para el [DAY] [DATE] a las [TIME]!
Su punto de encuentro será en el Lobby del Hotel. Por favor estar puntual.
Realizará el pago del servicio a la llegada al Mall.
```

---

## Scenario #3: Bayahíbe Special Case

### Steps 1-6: Same as VIP Service

### 7. Group Size Selection (Bayahíbe Only)
**Elija la cantidad de personas:**
- **Menos de 15 personas** (1) - Small bus pricing
- **Más de 15 personas** (2) - Large bus pricing

*This step only appears for Bayahíbe hotels after VIP service confirmation.*

### 8. Schedule Selection, User Information, Confirmation
Same as VIP service flow.

---

## Special Cases and Error Handling

### Hotel Not Found ("No lo sé" or "No está en la lista")
- System asks: "Por favor escriba el nombre de su hotel"
- Performs fuzzy matching against hotel database
- If **no matches**: Transfers to manual handling
- If **one match**: Proceeds with that hotel
- If **multiple matches**: Shows list for user selection

### Invalid Input Handling
- System validates all inputs and re-prompts on invalid data
- Maintains current conversation state until valid input received
- Provides helpful error messages in user's selected language

### "Will Text Later" Option
- Available at schedule selection step
- Ends conversation with reminder message to complete reservation later

---

## Technical Implementation Notes

### State Machine
- Each step is implemented as a separate state class
- States handle validation and determine next step transitions
- Context maintains user data throughout conversation

### Multilingual Support
- Messages available in 6 languages
- Language selection affects all subsequent messages
- Default fallback to Spanish for invalid language selection

### Data Validation
- **Dates**: Multiple format support with date parsing
- **Phone**: International format support with cleaning
- **Email**: Regex validation for proper format
- **Numbers**: Range validation for adults/children counts

### Database Integration
- Hotels, routes, and schedules stored in database
- Reservations saved with complete user information
- Conversation state persisted for session management

---

## NOT IMPLEMENTED

❌ **Referral Flows** - These scenarios from the original document are **NOT implemented**:
- Referidor con código
- Nuevo referidor  
- Client type selection step

❌ **Complex Pricing Calculations** - Pricing is handled as basic configuration per zone

❌ **Payment Processing** - System only confirms reservations, payment handled separately

---

*Last Updated: Based on current codebase implementation with all 226 tests passing*