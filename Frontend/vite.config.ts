import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react-swc';

export default defineConfig({
  server: {
    port: 10000,
    host: '0.0.0.0',
  },
  plugins: [react()],
});
