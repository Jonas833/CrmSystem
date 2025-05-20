window.calendarFunctions = {
    initializeCalendarWithEvents: function (termine) {
        console.log("Termine empfangen:", termine);

        var calendarEl = document.getElementById('calendar');

        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            events: termine, // <- korrekt
            timeZone: 'local' // optional, damit Zeiten richtig interpretiert werden
        });

        calendar.render();
    }
};
