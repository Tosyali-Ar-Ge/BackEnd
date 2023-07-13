import {
    Button,
    Text,
    View
} from 'react-native'

import React from 'react'
import { SafeAreaView } from 'react-native-safe-area-context'
import styles from '../HomeOthers/HomeOthersStyles'
import { useSelector } from 'react-redux'

function HomeOtherScreen({ navigation }) {
    const storeUser = useSelector(s => s.user)

    const createAudit = () => {
        navigation.navigate('CreateAudit');
    }
    const audits = () => {
        navigation.navigate('Audits');
    }

    return (
        <SafeAreaView style={{ flex: 1 }}>
            <View style={styles.topView}>
                <Text>{" Hoşgeldin Other " + storeUser.Name + " : " + storeUser.Role}</Text>
            </View>
            <View style={styles.buttonView}>
                <Button
                    onPress={createAudit}
                    title="Denetim Oluştur"
                    style={styles.buttonCreateAudit}
                />
                <Button
                    onPress={audits}
                    title="Denetimler"
                    style={styles.buttonAudits}
                />
            </View>
            <View style={styles.bottomView}>

            </View>
        </SafeAreaView>
    )
}

export default HomeOtherScreen