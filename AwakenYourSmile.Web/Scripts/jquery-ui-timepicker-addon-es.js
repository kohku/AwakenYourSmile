/* Inicialización en español para la extensión 'UI date picker' para jQuery. */
/* Traducido por Vester (xvester@gmail.com). */
jQuery(function ($) {
    $.timepicker.regional['es'] = {
        timeOnlyTitle: 'Tiempo',
        timeText: 'Tiempo',
        hourText: 'Hora',
        minuteText: 'Minuto',
        secondText: 'Segundo',
        millisecText: 'Milisegundo',
        timezoneText: 'Zona horaria',
        currentText: 'Hoy',
        closeText: 'Cerrar',
        timeFormat: 'HH:mm',
        amNames: ['AM', 'A'],
        pmNames: ['PM', 'P'],
        isRTL: false
    };
    $.timepicker.setDefaults($.timepicker.regional['es']);
});