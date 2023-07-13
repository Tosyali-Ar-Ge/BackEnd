import axios from 'axios';

const BASE_URL = 'http://10.0.2.2:5262/api/Users';

const userService = {
    login: async (userDtoForLogin) => {
        const url = `${BASE_URL}/login`;

        try {
            const response = await axios.post(url, userDtoForLogin);
            const user = response.data;
            return user;
        } catch (error) {
            console.log(error.message);
            throw new Error('Server erişim hatası');
        }
    },
};

export default userService;