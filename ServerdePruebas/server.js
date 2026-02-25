import express from 'express';
import PDFDocument from 'pdfkit';

import { getDeudaData } from './getDeuda.js';
import { generateNotificacionDeudaPDF } from './getDeuda.js';

// ----------------------------------------------------------------------
//  Configuración del servidor Express
// ----------------------------------------------------------------------
const app = express();
const PORT = 3000;

// Endpoint para notificación de una deuda específica
app.get('/notificacion-deuda-pdf', async (req, res) => {
  const cuil = req.query.cuil;
  const idDeuda = req.query.idDeuda;

    if (!cuil) {
        return res.status(400).send('Error: Debes proporcionar un cuil con ?cuil=XXX');
    }
    if (!idDeuda) {
        return res.status(400).send('Error: Debes proporcionar el id de la deuda con ?idDeuda=XXX');
    }

    try {
        // Obtener todas las deudas del contribuyente
        const deudas = await getDeudaData(cuil);

        // Buscar la deuda específica por ID
        const deuda = deudas.find(d => d.ID_DGROBLI01 === idDeuda);
        if (!deuda) {
        return res.status(404).send('No se encontró la deuda con el ID proporcionado');
        }

    // Crear PDF
    const doc = new PDFDocument({ margin: 50, size: 'A4' });
    res.setHeader('Content-Type', 'application/pdf');
    res.setHeader('Content-Disposition', `attachment; filename="notificacionATP-${cuil}-${idDeuda}.pdf"`);

    doc.pipe(res);
    generateNotificacionDeudaPDF(doc, deuda, cuil);
    doc.end();

    } catch (error) {
        console.error('Error generando PDF de notificación:', error);
        res.status(500).send('Error interno al generar el PDF');
    }
});

// Endpoint de prueba (opcional)
app.get('/', (_req, res) => {
    res.send('Servidor de notificaciones de deuda funcionando');
});

// Iniciar servidor
app.listen(PORT, () => {
    console.log(`✅ Servidor corriendo en http://localhost:${PORT}`);
}).on('error', (err) => {
    console.error('❌ Error al iniciar el servidor:', err.message);
});