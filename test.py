
import pydeck
import pandas

data = pandas.DataFrame([
    {
        'site': 'Big Ben',
        'attraction_type': 'Clock Tower',
        'lat': 51.5006958,
        'lng': -0.1266639
    },
    {
        'site': 'Kensington Palace',
        'attraction_type': 'Palace',
        'lat': 51.5046188,
        'lng': -0.1839472
    },
    {
        'site': 'Buckingham Palace',
        'attraction_type': 'Palace',
        'lat': 51.501364,
        'lng': -0.14189
    }
])

color_lookup = mapper.data_utils.assign_random_colors(data['attraction_type'])

# Assign a color based on attraction_type
data['color'] = data.apply(lambda row: color_lookup.get(row['attraction_type']), axis=1)

# Data now has an RGB color by attraction type
# [
#   {
#         'site': 'Big Ben',
#         'attraction_type': 'Clock Tower',
#         'lat': 51.5006958,
#         'lng': -0.1266639,
#         'color': [0, 10, 35]
#     },
#     {
#         'site': 'Kensington Palace',
#         'attraction_type': 'Palace',
#         'lat': 51.5046188,
#         'lng': -0.1839472,
#         'color': [53, 243, 130]
#     },
#   {
#         'attraction_type': 'Palace',
#         'site': 'Buckingham Palace',
#         'lat': 51.501364,
#         'lng': -0.14189,
#         'color': [53, 243, 130]
#     }
# ]
