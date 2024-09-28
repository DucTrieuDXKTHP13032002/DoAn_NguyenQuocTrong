const yourIP = 'localhost'; // See the docs https://docs.abp.io/en/abp/latest/Getting-Started-React-Native?Tiered=No
const port = 44305;
const apiUrl = `http://${yourIP}:${port}`;
const ENV = {
  dev: {
    apiUrl: apiUrl,
    oAuthConfig: {
      issuer: apiUrl,
      clientId: 'QLSV_App',
      scope: 'offline_access QLSV',
    },
    localization: {
      defaultResourceName: 'QLSV',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44305',
    oAuthConfig: {
      issuer: 'http://localhost:44305',
      clientId: 'QLSV_App',
      scope: 'offline_access QLSV',
    },
    localization: {
      defaultResourceName: 'QLSV',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
