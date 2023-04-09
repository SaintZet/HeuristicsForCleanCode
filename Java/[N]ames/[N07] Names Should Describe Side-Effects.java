public ObjectOutputStream getOos() throws IOException {
    if (m_oos == null) {
        m_oos = new ObjectOutputStream(m_socket.getOutputStream());
    }
    return m_oos;
}
// This function does a bit more than get an "oos"; 
// it creates the "oos" if it hasn't been created already. 
// Thus, a better name might be createOrReturnOos.