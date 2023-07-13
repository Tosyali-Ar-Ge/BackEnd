import { StyleSheet } from "react-native";
import { _colorsEnum} from "../Enums/colorEnums"

const colorsEnum = {

}

const flexEnum = {
    topFlex: 1,

    bottomFlex: 1,
}

const styles = StyleSheet.create({
    nbProvider : {
        flex:1,
        backgroundColor:_colorsEnum.nbProvider
    },
    

    topView: {
        flex: flexEnum.topFlex,
    },

    bottomView: {
        flex: flexEnum.bottomFlex,
    },

});

export default styles;