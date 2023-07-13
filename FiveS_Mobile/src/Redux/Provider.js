import { Provider } from 'react-redux'
import React from 'react'
import { configureStore } from '@reduxjs/toolkit'
import reducer from './reducers'

const UserProvider = ({ children }) => {
    const store = configureStore({ reducer: reducer })
    return (
        <Provider store={store}>
            {children}
        </Provider>)
}

export default UserProvider