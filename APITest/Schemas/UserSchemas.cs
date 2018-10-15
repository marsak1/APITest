using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Schemas
{
    public class UserSchemas
    {
        public JSchema GetUserSchema()
        {
            JSchema UserSchema = JSchema.Parse(
                @"{
                  'type': 'object',
                  'properties': {
                    'id': {
                      'type': 'integer'
                    },
                    'name': {
                      'type': 'string'
                    },
                    'username': {
                      'type': 'string'
                    },
                    'email': {
                      'type': 'string'
                    },
                    'address': {
                      'type': 'object',
                      'properties': {
                        'street': {
                          'type': 'string'
                        },
                        'suite': {
                          'type': 'string'
                        },
                        'city': {
                          'type': 'string'
                        },
                        'zipcode': {
                          'type': 'string'
                        },
                        'geo': {
                          'type': 'object',
                          'properties': {
                            'lat': {
                              'type': 'string'
                            },
                            'lng': {
                              'type': 'string'
                            }
                          },
                          'required': [
                            'lat',
                            'lng'
                          ]
                        }
                      }
                    },
                    'phone': {
                      'type': 'string'
                    },
                    'website': {
                      'type': 'string'
                    },
                    'company': {
                      'type': 'object',
                      'properties': {
                        'name': {
                          'type': 'string'
                        },
                        'catchPhrase': {
                          'type': 'string'
                        },
                        'bs': {
                          'type': 'string'
                        }
                      },
                      'required': [
                        'name',
                        'catchPhrase',
                        'bs'
                      ]
                    }
                  }}"
            );

            UserSchema.AllowAdditionalItems = false;

            return UserSchema;
        }

        public JSchema GetUsersSchema()
        {
            JSchema UsersSchema = JSchema.Parse(
                   @"{
                      'type': 'array',
                      'properties': {
                        'id': {
                         'type': 'integer'
                         },
                        'name': {
                          'type': 'string'
                        },
                        'username': {
                          'type': 'string'
                        },
                        'email': {
                          'type': 'string'
                        },
                        'address': {
                          'type': 'object',
                          'properties': {
                            'street': {
                              'type': 'string'
                            },
                            'suite': {
                              'type': 'string'
                            },
                            'city': {
                              'type': 'string'
                            },
                            'zipcode': {
                              'type': 'string'
                            },
                            'geo': {
                              'type': 'object',
                              'properties': {
                                'lat': {
                                  'type': 'string'
                                },
                                'lng': {
                                  'type': 'string'
                                }
                              },
                              'required': [
                                'lat',
                                'lng'
                              ]
                            }
                          }
                        },
                        'phone': {
                          'type': 'string'
                        },
                        'website': {
                          'type': 'string'
                        },
                        'company': {
                          'type': 'object',
                          'properties': {
                            'name': {
                              'type': 'string'
                            },
                            'catchPhrase': {
                              'type': 'string'
                            },
                            'bs': {
                              'type': 'string'
                            }
                          },
                          'required': [
                            'name',
                            'catchPhrase',
                            'bs'
                          ]
                        },
                        'id': {
                          'type': 'integer'
                        }
                      }
                    }");


            return UsersSchema;
        }
    }

    
}
