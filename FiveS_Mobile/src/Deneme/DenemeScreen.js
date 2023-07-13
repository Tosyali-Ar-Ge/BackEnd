import {
    Button,
    SafeAreaView,
    Text,
    View
}
    from 'react-native'

import React from 'react'
import { createStore } from 'redux'
import { useEffect } from 'react';
import { useSelector } from 'react-redux';
import { useState } from 'react';

function DenemeScreen() {
    let storeUser = createStore(userReducer)
    const [value, setValue] = useState(0);

    function userReducer(state = { value }, action) {
        switch (action.type) {
            case 'user/update':
                console.log("user/update , girdim")
                return { value: action.payload }
            default:
                return state
        }
    }
    function handlePress() {
        storeUser.dispatch({ type: 'user/update', payload: { id: 1, name: "zeki" } })
    }
    storeUser.subscribe(() => {
        // console.log(storeUser.getState().value)
        // setValue(storeUser.getState().value)
    });
    return (
        <SafeAreaView style={{ flex: 1 }}>
            <View style={{ flex: 1 }}>
                <Text>{value.id}</Text>
            </View>
            <View style={{ flex: 1 }}>
                <Button title="Arttır" onPress={handlePress} />
            </View>
            <View style={{ flex: 1 }}>
                <Text>{value.name}</Text>
            </View>
        </SafeAreaView>
    )
}

export default DenemeScreen