import fs from 'fs';

// ----------------------------------------------------------------------
// 1. Simulación de obtención de datos (reemplazar con llamada real a ws_estadodeuda)
// ----------------------------------------------------------------------
export async function getDeudaData(contribuyenteId) {
  // Datos de ejemplo – en nuestro caso vendrán del servicio o base de datos
    return [
        {
        DGROBLI11_FECHAVTODDJJ: "2023/05/10",
        DGROBLI11_FECHAVTOPAGO: "2023/06/15",
        DGROBLI11_POSICIONFISCAL: "202305",
        DGRTRIB01_DESCRI: "Ingresos Brutos",
        DGRTRIB03_CODIGO: "IIBB",
        DGRTRIB03_DESCRI: "Anticipo Mensual",
        DGRTRIB06_CODIGO: "REG01",
        DGRTRIB06_DESCRI: "Régimen General",
        ESTADO: "Pendiente",
        ESTADO_OBLI: "Vencido",
        ID_DGROBLI01: "1",
        ID_DGRTRIB06: "101",
        INTERESES: "1500.50",
        RECARGO: "200.00",
        RELA_DGRTRIB01: "10",
        SALDO: "12500.75",
        SALDO_HIS: "10800.25",
        },
        {
        DGROBLI11_FECHAVTODDJJ: "2023/04/10",
        DGROBLI11_FECHAVTOPAGO: "2023/05/15",
        DGROBLI11_POSICIONFISCAL: "202304",
        DGRTRIB01_DESCRI: "Ingresos Brutos",
        DGRTRIB03_CODIGO: "IIBB",
        DGRTRIB03_DESCRI: "Anticipo Mensual",
        DGRTRIB06_CODIGO: "REG01",
        DGRTRIB06_DESCRI: "Régimen General",
        ESTADO: "Boleta Deuda",
        ESTADO_OBLI: "Intimado",
        ID_DGROBLI01: "2",
        ID_DGRTRIB06: "101",
        INTERESES: "2500.00",
        RECARGO: "300.00",
        RELA_DGRTRIB01: "10",
        SALDO: "18900.30",
        SALDO_HIS: "16100.30",
        }
    ];
}

// ----------------------------------------------------------------------
// 2. Utilidades de formato
// ----------------------------------------------------------------------
function formatearFecha(fecha) {
    if (!fecha) return "Sin fecha";
    const [anio, mes, dia] = fecha.split('/');
    return `${dia}/${mes}/${anio}`;
}

// ----------------------------------------------------------------------
// 3. Generador del PDF de notificación (una sola deuda)
// ----------------------------------------------------------------------
export function generateNotificacionDeudaPDF(doc, deuda, cuil) {
    const margin = 50;
    let y = margin;

    // --------------------------------------------------------------
    // Variables de configuración para logo y título
    // --------------------------------------------------------------
    const logoWidth = 60;            // Ancho del logo en puntos
    const logoHeight = 60;           // Alto del logo (si se omite, se escala proporcionalmente)
    const titleOffsetX = 70;          // Espacio horizontal entre logo y título
    const titleOffsetY = 3;           // Ajuste vertical para alinear título con logo (puede ser negativo)
    // --------------------------------------------------------------

    // Logo y título en la misma línea
    if (fs.existsSync('./logo.png')) {
        // Logo con tamaño configurable
        doc.image('./logo.png', 60, 20, { width: logoWidth, height: logoHeight });
        // Título a la derecha del logo, con desplazamiento configurable
        doc.fontSize(16).font('Helvetica-Bold').text(
            'NOTIFICACIÓN DE DEUDA VENCIDA',
            margin + logoWidth + titleOffsetX,
            y + titleOffsetY
        );
    } else {
        console.warn('Logo no encontrado');
        doc.fontSize(16).font('Helvetica-Bold').text('NOTIFICACIÓN DE DEUDA VENCIDA', margin, y);
    }
    y += 40; // Espacio después del logo y título

    // Datos del contribuyente
    doc.fontSize(12).font('Helvetica-Bold').text('Contribuyente:', margin, y);
    doc.font('Helvetica').text(`CUIL: ${cuil}`, margin + 100, y);
    y += 25;

    // Fecha de emisión
    doc.fontSize(10).font('Helvetica').text(`Fecha de emisión: ${new Date().toLocaleDateString('es-AR')}`, margin, y);
    y += 30;

    // Recuadro con detalle de la deuda
    doc.rect(margin, y, doc.page.width - 2 * margin, 180).stroke();
    doc.fontSize(14).font('Helvetica-Bold').text('Detalle de la deuda', margin + 10, y + 10);

    const posicionFiscal = deuda.DGROBLI11_POSICIONFISCAL;
    const anio = posicionFiscal.substring(0, 4);
    const mes = posicionFiscal.substring(4, 6);
    const periodo = `${mes}/${anio}`;
    const saldo = parseFloat(deuda.SALDO) || 0;
    const saldoHis = parseFloat(deuda.SALDO_HIS) || 0;
    const intereses = parseFloat(deuda.INTERESES) || 0;
    const recargo = parseFloat(deuda.RECARGO) || 0;

    let detalleY = y + 35;
    doc.fontSize(11).font('Helvetica');
    doc.text(`Período: ${periodo}`, margin + 20, detalleY);
    doc.text(`Impuesto: ${deuda.DGRTRIB01_DESCRI}`, margin + 20, detalleY + 15);
    doc.text(`Régimen: ${deuda.DGRTRIB06_DESCRI}`, margin + 20, detalleY + 30);
    doc.text(`Concepto: ${deuda.DGRTRIB03_DESCRI}`, margin + 20, detalleY + 45);

    doc.text(`Capital: $${saldoHis.toLocaleString('es-AR', { minimumFractionDigits: 2 })}`, doc.page.width / 2, detalleY);
    if (intereses > 0) {
        doc.text(`Intereses: $${intereses.toLocaleString('es-AR', { minimumFractionDigits: 2 })}`, doc.page.width / 2, detalleY + 15);
    }
    if (recargo > 0) {
        doc.text(`Recargos: $${recargo.toLocaleString('es-AR', { minimumFractionDigits: 2 })}`, doc.page.width / 2, detalleY + 30);
    }
    doc.font('Helvetica-Bold').text(`Total adeudado: $${saldo.toLocaleString('es-AR', { minimumFractionDigits: 2 })}`, doc.page.width / 2, detalleY + 50);

    doc.font('Helvetica');
    doc.text(`Fecha de vencimiento: ${formatearFecha(deuda.DGROBLI11_FECHAVTOPAGO)}`, margin + 20, detalleY + 70);
    doc.text(`Fecha de declaración jurada: ${formatearFecha(deuda.DGROBLI11_FECHAVTODDJJ) || 'No disponible'}`, margin + 20, detalleY + 85);
    y += 210;

    // Mensaje de notificación (fondo rojo claro)
    doc.rect(margin, y, doc.page.width - 2 * margin, 80).fill('#f8d7da').stroke('#721c24');
    doc.fillColor('#721c24');
    doc.fontSize(13).font('Helvetica-Bold').text('NOTIFICACIÓN', margin + 10, y + 10);
    doc.fontSize(11).font('Helvetica').text(
        'La deuda detallada se encuentra vencida y no registra pago. Le recordamos la obligación de regularizar su situación fiscal a la brevedad para evitar intereses adicionales y posibles acciones de cobro.',
        margin + 10,
        y + 30,
        { width: doc.page.width - 2 * margin - 20, align: 'justify' }
    );
    doc.fillColor('black');
    y += 100;

    // Instrucciones para regularizar
    doc.fontSize(12).font('Helvetica-Bold').text('¿Cómo regularizar?', margin, y);
    y += 20;
    doc.fontSize(10).font('Helvetica').text(
        '• Puede acercarse a nuestras oficinas con el presente comprobante.\n' +
        '• Si ya realizó el pago, por favor ignore esta notificación.',
        margin,
        y,
        { lineGap: 5 }
    );
    y += 60;

    // Pie de página
    doc.fontSize(8).font('Helvetica').text(
        'Este documento es una notificación automática. Para consultas, comuníquese a administraciontributaria@formosa.gob.ar.',
        margin,
        doc.page.height,
        { align: 'center' }
    );
}